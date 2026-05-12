using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public string gameSceneName = "House";
    public GameObject credits;
    public GameObject loadText;
    public GameObject title;

 
    public void startGame()
    {
        title.SetActive(false);
        credits.SetActive(false);
        loadText.SetActive(true);

        SceneManager.LoadScene(gameSceneName);
    }


}
