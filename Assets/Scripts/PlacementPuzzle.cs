using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlacementPuzzle : MonoBehaviour
{
    public List<bool> currentPuzzleState = new List<bool> { false, false, false, false }; // current correct placements
    public UnityEvent puzzleSolved;
    public bool isSolved = false;

    public void updateCorrect(int currPlacement)
    {
        currentPuzzleState[currPlacement] = true;
        checkComplete();
    }

    public void updateIncorrect(int currPlacement)
    {
        currentPuzzleState[currPlacement] = false;
        checkComplete();
    }

    private void checkComplete()
    {
        if (isSolved)
        {
            return;
        }

    // Check every puzzle state entry
    foreach (bool state in currentPuzzleState)
    {
        if (!state)
        {
            return;
        }
    }

    Debug.Log("Puzzle Solved!");

    isSolved = true;
    puzzleSolved.Invoke();
    }

   
}
