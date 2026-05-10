using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockChest : MonoBehaviour
{
    public GameObject loreBook;
    public GameObject Key;
    public GameObject OldChest;
    public GameObject NewChest;
    public AudioSource chestAudioSource;
    public AudioClip chestAudioClip;
    private bool unlocked = false;


    public void unlockChest()
    {
        if (unlocked == false)
        {
        loreBook.SetActive(true);
        Key.SetActive(true);
        OldChest.SetActive(false);
        NewChest.SetActive(true);

        chestAudioSource.PlayOneShot(chestAudioClip);
        unlocked = true;
        }

    }
    
}
