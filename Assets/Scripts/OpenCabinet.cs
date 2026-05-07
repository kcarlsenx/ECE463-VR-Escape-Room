using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class OpenCabinet : MonoBehaviour
{
    public Transform cabinetDoorOrDrawer;
    public Vector3 openOffset = new Vector3(0.4f, 0f, 0f);

    public GameObject objectToReveal;

    private Vector3 closedPosition;
    private bool opened = false;
    private float timer;
    public AudioSource cabinentAudio;
    public AudioClip cabinentMoveClip;

    private void Start()
    {
        if (cabinetDoorOrDrawer != null)
            closedPosition = cabinetDoorOrDrawer.localPosition;

        if (cabinentAudio != null)
            cabinentAudio = GetComponent<AudioSource>();
    }

    public void Open()
    {
        if (opened || cabinetDoorOrDrawer == null) return;

        cabinetDoorOrDrawer.localPosition = closedPosition + openOffset;
        playCabinentSound();

        if (objectToReveal != null)
            timer += Time.deltaTime;

            if (timer >= 1f)
            {
            objectToReveal.transform.position = new Vector3(
                2.8944259f,
                0.8840437f,
                -3.900727f);        
            }
    

        opened = true;

        Debug.Log("Cabinet opened");
    }

    private void playCabinentSound()
    {
        if (cabinentAudio != null && cabinentMoveClip != null)
        {
            cabinentAudio.pitch = Random.Range(0.9f, 1.1f);
            cabinentAudio.PlayOneShot(cabinentMoveClip);
        }
    }

}

