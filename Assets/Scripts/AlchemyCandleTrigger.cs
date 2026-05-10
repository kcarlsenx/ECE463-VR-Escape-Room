using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlchemyCandleTrigger : MonoBehaviour
{
    public bool isActive = false;

    public BasementPuzzleManager basementManager;
    public AlchemyPuzzleController puzzleController;

    public GameObject flameObject;

    public AudioSource audioSource;
    public AudioClip igniteClip;
    public AudioClip extinguishClip;

    private void OnTriggerEnter(Collider other)
    {
        if (basementManager == null || !basementManager.bookPuzzleSolved)
            return;

        if (!other.CompareTag("Candle"))
            return;

        TurnOn();
    }

    public void TurnOn()
    {
        if (isActive)
            return;

        isActive = true;

        if (flameObject != null)
            flameObject.SetActive(true);

        if (audioSource != null && igniteClip != null)
            audioSource.PlayOneShot(igniteClip);

        if (puzzleController != null)
            puzzleController.CheckPuzzle();
    }

    public void TurnOff()
    {
        if (!isActive)
            return;

        isActive = false;

        if (flameObject != null)
            flameObject.SetActive(false);

        if (audioSource != null && extinguishClip != null)
            audioSource.PlayOneShot(extinguishClip);

        if (puzzleController != null)
            puzzleController.CheckPuzzle();
    }
}
