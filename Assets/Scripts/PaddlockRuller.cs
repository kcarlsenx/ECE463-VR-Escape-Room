using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PadlockRuller : MonoBehaviour
{
    public int currentNumber = 0;

    public float rotationStep = 36f;

    public PadlockPassword passwordManager;

    public int wheelIndex;
    public AudioSource lockAduioSource;
    public AudioClip lockAudioSound;

    void Start()
    {
        lockAduioSource = GetComponent<AudioSource>();

    }

    public void changeLock()
    {
        transform.Rotate(
            -rotationStep,
            0,
            0,
            Space.Self
        );

        lockAduioSource.PlayOneShot(lockAudioSound);
        currentNumber++;

        if (currentNumber > 9)
        {
            currentNumber = 0;
        }

        passwordManager.UpdatePassword(
            wheelIndex,
            currentNumber
        );
    }
}