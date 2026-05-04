using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenCabinet : MonoBehaviour
{
    public Transform cabinetDoorOrDrawer;
    public Vector3 openOffset = new Vector3(0.4f, 0f, 0f);

    public GameObject objectToReveal;

    private Vector3 closedPosition;
    private bool opened = false;

    private void Start()
    {
        if (cabinetDoorOrDrawer != null)
            closedPosition = cabinetDoorOrDrawer.localPosition;

        if (objectToReveal != null)
            objectToReveal.SetActive(false);
    }

    public void Open()
    {
        if (opened || cabinetDoorOrDrawer == null) return;

        cabinetDoorOrDrawer.localPosition = closedPosition + openOffset;

        if (objectToReveal != null)
            objectToReveal.SetActive(true);

        opened = true;

        Debug.Log("Cabinet opened");
    }
}