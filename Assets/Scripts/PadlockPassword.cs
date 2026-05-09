using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Meta.XR.MRUtilityKit.BuildingBlocks;
using UnityEngine;
using UnityEngine.Events;



public class PadlockPassword : MonoBehaviour
{
    public int[] currentNumbers = { 0, 0, 0, 0 };

    public int[] correctPassword = { 0, 0, 0, 0 };
    public UnityEvent onUnlocked; // Unlock event trigger

    public void UpdatePassword(int index, int value)
    {
        currentNumbers[index] = value;

        CheckPassword();
    }

    private void CheckPassword()
    {
        if (currentNumbers.SequenceEqual(correctPassword))
        {
            Debug.Log("Password correct");
            StartCoroutine(UnlockEffect(gameObject));
            onUnlocked.Invoke();
        }
    }

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