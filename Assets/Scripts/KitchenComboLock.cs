using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class KitchenComboLock : MonoBehaviour
{
    public List<int> correctCode = new List<int> { 4, 2, 7 };
    private List<int> currentCode = new List<int>();

    public TMP_Text displayText;

    public UnityEvent onSuccess;

    private bool unlocked = false;

    private void Start()
    {
        for (int i = 0; i < correctCode.Count; i++)
        {
            currentCode.Add(0);
        }

        UpdateDisplay();
    }

    public void IncrementDigit(int index)
    {
        if (unlocked) return;

        currentCode[index] = (currentCode[index] + 1) % 10;

        UpdateDisplay();
        CheckCode();
    }

    private void UpdateDisplay()
    {
        if (displayText != null)
        {
            displayText.text = string.Join("", currentCode);
        }
    }

    private void CheckCode()
    {
        for (int i = 0; i < correctCode.Count; i++)
        {
            if (currentCode[i] != correctCode[i])
            {
                return;
            }
        }

        unlocked = true;
        Debug.Log("Kitchen LOCK CORRECT");
        onSuccess?.Invoke();
    }
}