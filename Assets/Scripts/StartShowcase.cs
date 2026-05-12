using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartShowcase : MonoBehaviour
{
    public float delayBeforeSceneChange = 3f;
    public string gameSceneName = "showcase";
    public GameObject credits;
    public GameObject loadText;
    public GameObject title;
 
    private AsyncOperation loadOperation;

    private void Start()
    {
        loadOperation =
            SceneManager.LoadSceneAsync(
                gameSceneName,
                LoadSceneMode.Single
            );

        loadOperation.allowSceneActivation = false;
    }

 
    public void startShowcase()
    {
        title.SetActive(false);
        credits.SetActive(false);
        loadText.SetActive(true);
        StartCoroutine(LoadEndingAfterDelay());
    }


     private IEnumerator LoadEndingAfterDelay()
    {
        yield return new WaitForSeconds(delayBeforeSceneChange);
         loadOperation.allowSceneActivation = true;
    } 


}
