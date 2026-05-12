using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowCredits : MonoBehaviour
{
    public GameObject credits;
    private bool isCredits = false;
    public GameObject title;

    void Start()
    {
        if (credits != null)
        {
            credits.SetActive(false);
            title.SetActive(true);
            
        }
    }

    
    public void toggleCredits()
    {
        if (credits != null && isCredits == false)
        {
            title.SetActive(false);
            credits.SetActive(true);
            isCredits = true;
        }
        else
        {
            credits.SetActive(false);
            isCredits = false;
            title.SetActive(true);
        }
    }
}
