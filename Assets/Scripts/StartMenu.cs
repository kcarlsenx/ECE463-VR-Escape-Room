using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public string gameSceneName = "Menu";
    public GameObject loadText;

 
    public void startMenu()
    {
        loadText.SetActive(true);
        SceneManager.LoadScene(gameSceneName);
    }


}
