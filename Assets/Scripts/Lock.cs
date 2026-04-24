using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Lock : MonoBehaviour
{
    public int LockID; // ID value that associates with key ID
    public UnityEvent onUnlocked; // Unlock event trigger

    // Trigger when lock is opened
    private void OnDisable()
    {
        onUnlocked.Invoke();
    }
}
