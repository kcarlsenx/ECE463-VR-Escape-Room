using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoveKnob : MonoBehaviour
{
    public int currentState = 0;
    // 0 = Off, 1 = Low, 2 = Medium, 3 = High

    public float rotationStep = 30f;
    public StoveManager stoveManager;

    public AudioSource clickSound;

    public void OnInteract()
    {
        currentState = (currentState + 1) % 4;

        transform.localRotation = Quaternion.Euler(currentState * rotationStep, 0, 0);
        if (clickSound != null)
        {
            clickSound.Play();
        }
        if (stoveManager != null)
        {
            stoveManager.OnKnobTurned();
        }
        else
        {
            Debug.LogError("StoveManager missing on " + gameObject.name);
        }
    }

    private void OnMouseDown() // for testing in unity
    {
        OnInteract();
    }

    public void OnSelect()
    {
        OnInteract();
    }
}