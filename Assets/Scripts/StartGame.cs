using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public float delayBeforeSceneChange = 3f;
    public string gameSceneName = "House";
    public GameObject credits;
    public GameObject loadText;

 
    public void startGame()
    {
        credits.SetActive(false);
        loadText.SetActive(true);

        SceneManager.LoadScene(gameSceneName);
    }


}
