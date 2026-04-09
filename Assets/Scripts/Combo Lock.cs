using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class PasscodeSystem : MonoBehaviour
{

    public List<int> correctCode = new List<int> { 1, 2, 3, 4 };

    private List<int> currentInput = new List<int>();

    public UnityEvent onSuccess;
    public UnityEvent onFailure;
    public TMP_Text displayText;

    // Call this when a number button is pressed
    public void EnterDigit(int digit)
    {
        currentInput.Add(digit);
        Debug.Log("Entered: " + digit);
        UpdateDisplay();

        // Check as soon as we reach 4 digits
        if (currentInput.Count == correctCode.Count)
        {
            CheckCode();
        }
    }

private void UpdateDisplay()
    {

            displayText.text = string.Join("", currentInput);
    }


    private void CheckCode()
    {
        bool isCorrect = true;

        for (int i = 0; i < correctCode.Count; i++)
        {
            if (currentInput[i] != correctCode[i])
            {
                isCorrect = false;
                break;
            }
        }

        if (isCorrect)
        {
            Debug.Log("PASSCODE CORRECT");
            onSuccess?.Invoke();
        }
        else
        {
            Debug.Log("PASSCODE WRONG");
            onFailure?.Invoke();
        }

        // Reset for next attempt
        currentInput.Clear();
    }

    // Reset code (will be used later)
    public void ResetInput()
    {
        currentInput.Clear();
    }
}