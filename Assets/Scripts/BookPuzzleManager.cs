using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BookPuzzleManager : MonoBehaviour
{
    public int requiredCorrectCount = 4;
    public UnityEvent onPuzzleSolved;

    private int currentCorrectCount = 0;
    private bool solved = false;

    public void AddCorrectBook()
    {
        if (solved)
            return;

        currentCorrectCount++;

        if (currentCorrectCount >= requiredCorrectCount)
        {
            solved = true;
            onPuzzleSolved.Invoke();
        }
    }
}