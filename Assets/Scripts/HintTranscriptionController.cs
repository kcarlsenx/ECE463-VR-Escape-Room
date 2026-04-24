using UnityEngine;
using Oculus.Voice;

public class HintTranscriptionController : MonoBehaviour
{
    [SerializeField] private HintSystem hintSystem;
    [SerializeField] private AppVoiceExperience appVoiceExperience;
    private bool isListening = false;


    private void Awake()
    {
        if (appVoiceExperience == null)
            appVoiceExperience = GetComponent<AppVoiceExperience>();
    }

    private void OnEnable()
    {
        if (appVoiceExperience != null)
            appVoiceExperience.VoiceEvents.OnFullTranscription.AddListener(HandleFullTranscription);
    }

    private void OnDisable()
    {
        if (appVoiceExperience != null)
            appVoiceExperience.VoiceEvents.OnFullTranscription.RemoveListener(HandleFullTranscription);
    }

    public void HandleFullTranscription(string text)
    {
        Debug.Log("Transcription received: " + text);

        string lowerText = text.ToLower();

        if (lowerText.Contains("hint") || lowerText.Contains("help") || lowerText.Contains("stuck"))
        {
            Debug.Log("Voice: Hint requested");
            hintSystem.ShowNextHint();
        }
    }

    // this should force users to hold the trigger to get hints, preventing accidental activations
    private void Update()
    {
        if (appVoiceExperience == null) return;

        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger) && !isListening)
        {
            Debug.Log("Mic Activated");
            appVoiceExperience.Activate();
            isListening = true;
        }

        if (OVRInput.GetUp(OVRInput.Button.PrimaryIndexTrigger) && isListening)
        {
            Debug.Log("Mic Deactivated");
            appVoiceExperience.Deactivate();
            isListening = false;
        }
    }
}