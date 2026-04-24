using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Oculus.Interaction;
using Unity.XR.CoreUtils;
using UnityEngine;
using UnityEngine.UIElements;

public class Key : MonoBehaviour
{
    public int KeyID; // ID value that associates with lock ID


    // Checks if key touches a lock and IDs match
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<Lock>(out Lock currLock) && KeyID == currLock.LockID)
        {
            StartCoroutine(UnlockEffect(other.gameObject));

        }
    }

    // Animation for lock unlocking
    private IEnumerator UnlockEffect(GameObject currLock)
    {

        float currScale = currLock.transform.localScale.x;


        while (currScale > 0.0)
        {
            currScale -= 0.1f;
            currLock.transform.localScale = new Vector3(currScale, currScale, currScale);
            yield return null;
        }

        currLock.SetActive(false);
    }
}


