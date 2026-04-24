using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Lock : MonoBehaviour
{
    public int LockID;
    public UnityEvent onUnlocked;

    private void OnDisable()
    {
        onUnlocked.Invoke();
    }
}
