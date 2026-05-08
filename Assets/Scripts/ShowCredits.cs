using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowCredits : MonoBehaviour
{
    public GameObject credits;
    private bool isCredits = false;

    void Start()
    {
        if (credits != null)
        {
            credits.SetActive(false);
            
        }
    }

    
    public void toggleCredits()
    {
        if (credits != null && isCredits == false)
        {
            credits.SetActive(true);
            isCredits = true;
        }
        else
        {
            credits.SetActive(false);
            isCredits = false;
        }
    }
}
