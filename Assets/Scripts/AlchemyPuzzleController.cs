using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AlchemyPuzzleController : MonoBehaviour
{
    public AlchemyCandleTrigger fixture1;
    public AlchemyCandleTrigger fixture2;
    public AlchemyCandleTrigger fixture3;
    public AlchemyCandleTrigger fixture4;

    public UnityEvent onPuzzleSolved;

    private bool solved = false;

    public void CheckPuzzle()
    {
        if (solved)
            return;

        if (
            fixture1.isActive &&
            !fixture2.isActive &&
            fixture3.isActive &&
            fixture4.isActive
        )
        {
            solved = true;
            onPuzzleSolved.Invoke();
            Debug.Log("Alchemy puzzle solved!");
        }
    }
}