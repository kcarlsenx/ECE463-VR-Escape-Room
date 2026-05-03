using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MurderWeaponFound : MonoBehaviour
{
    public float delayBeforeSceneChange = 3f;
    public string endingSceneName = "EndingScene";

    private bool found = false;

    public void FoundWeapon()
    {
        if (found) return;
        found = true;

        Debug.Log("Murder weapon found. Ending scene loading soon...");
        StartCoroutine(LoadEndingAfterDelay());
    }

    private IEnumerator LoadEndingAfterDelay()
    {
        yield return new WaitForSeconds(delayBeforeSceneChange);
        SceneManager.LoadScene(endingSceneName);
    }

    private void OnMouseDown()
    {
        FoundWeapon();
    }
}