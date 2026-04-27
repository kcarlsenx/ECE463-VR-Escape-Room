using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Lock : MonoBehaviour
{
    public int LockID; // ID value that associates with key ID
    public UnityEvent onUnlocked; // Unlock event trigger

    public AudioSource lockAudio;
    public AudioClip unlockClip;

    private void Start()
    {
        if (lockAudio == null)
            lockAudio = GetComponent<AudioSource>();
    }

    // Trigger when lock is opened
    private void OnDisable()
    {
        if (lockAudio != null && unlockClip != null)
        {
            lockAudio.PlayOneShot(unlockClip);
        }

        onUnlocked.Invoke();
    }
}
