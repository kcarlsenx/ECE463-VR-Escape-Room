using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class PasscodeSystem : MonoBehaviour
{

    public List<int> correctCode = new List<int> { 1, 2, 3, 4 }; // Lock password
    private List<int> currentInput = new List<int>(); // Curent inputed password
    public UnityEvent onSuccess; // Event when code is correct
    public UnityEvent onFailure; // Event when code is wrong
    public TMP_Text displayText; // Text for code interface

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

    // Updates text with user input
    private void UpdateDisplay()
    {

        displayText.text = string.Join("", currentInput);
    }

    // Checks is password was correct and calls event
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

    // Reset code for debugging
    public void ResetInput()
    {
        currentInput.Clear();
    }
}