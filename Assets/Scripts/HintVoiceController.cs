using System.Collections;
using System.Collections.Generic;
using Meta.WitAi;
using UnityEngine;

public class HintVoiceController : MonoBehaviour
{
    [SerializeField] private HintSystem hintSystem;

    private const string ASK_FOR_HINT_INTENT = "ask_hint";

    [MatchIntent(ASK_FOR_HINT_INTENT)]
    public void OnHintRequested()
    {
        Debug.Log("Voice: Hint requested");

        if (hintSystem != null)
        {
            hintSystem.ShowNextHint();
        }
        else
        {
            Debug.LogWarning("HintSystem not assigned!");
        }
    }
}