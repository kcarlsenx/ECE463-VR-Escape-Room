using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public float delayBeforeSceneChange = 3f;
    public string gameSceneName = "House";
 
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

 
    public void startGame()
    {
        StartCoroutine(LoadEndingAfterDelay());
    }


     private IEnumerator LoadEndingAfterDelay()
    {
        yield return new WaitForSeconds(delayBeforeSceneChange);
         loadOperation.allowSceneActivation = true;
    } 


}
