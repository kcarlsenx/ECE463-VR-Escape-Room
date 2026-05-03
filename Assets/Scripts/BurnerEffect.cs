using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurnerEffect : MonoBehaviour
{
    public Light burnerLight;

    public float lowIntensity = 1f;
    public float mediumIntensity = 3f;
    public float highIntensity = 6f;

    public void SetBurnerState(int state)
    {

        if (burnerLight == null)
        {
            return;
        }

        burnerLight.gameObject.SetActive(state != 0);
        burnerLight.enabled = state != 0;

        if (state == 1)
            burnerLight.intensity = lowIntensity;
        else if (state == 2)
            burnerLight.intensity = mediumIntensity;
        else if (state == 3)
            burnerLight.intensity = highIntensity;
        else
            burnerLight.intensity = 0f;

    }
}