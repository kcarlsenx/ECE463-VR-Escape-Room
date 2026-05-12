using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MurderWeaponFound : MonoBehaviour
{
    public float delayBeforeAudio = 2f;
    private bool found = false;
    public UnityEvent weaponFound;
    public GameObject returnButton;

    public void FoundWeapon()
    {
        if (found) return;
        found = true;

        weaponFound.Invoke();
        Debug.Log("Murder weapon found.");
        returnButton.SetActive(true);
    }
}