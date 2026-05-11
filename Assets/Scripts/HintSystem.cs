using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HintSystem : MonoBehaviour
{
    [SerializeField] private GameObject hintBox;
    [SerializeField] private TMP_Text hintText;

    [TextArea(2, 5)]
    [SerializeField] private string[] hints;

    private int currentPuzzle = 0;

    // Start is called before the first frame update
    private void Start()
    {
        if (hintBox != null)
        {
            hintBox.SetActive(true); // set it to active at the start, so the first hint is shown immediately
        }
    }

    public void ShowNextHint()
    {
        if (hints == null || hints.Length == 0)
        {
            Debug.LogWarning("No hints assigned.");
            return;
        }

        if (hintBox != null)
            hintBox.SetActive(true);

        if (hintText != null)
            hintText.text = hints[currentPuzzle];

    }

    public void finishPuzzle()
    {
        currentPuzzle++;
        Debug.Log("Finished puzzle: " + currentPuzzle);
        hintText.text = "Hints";
    }


    public void HideHintBox()
    {
        if (hintBox != null)
            hintBox.SetActive(false);
    }
}
