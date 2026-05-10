using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlacementTarget : MonoBehaviour
{
    public string placementID;

    public UnityEvent onCorrectPlacement;
    public UnityEvent onWrongPlacement;
    public UnityEvent onObjectRemoved;

    private bool isCorrectObjectInside = false;

    private void OnTriggerEnter(Collider other)
    {
        PlaceableObject obj = other.GetComponent<PlaceableObject>();

        if (obj == null)
            return;

        // Correct object
        if (obj.objectID == placementID)
        {
            if (!isCorrectObjectInside)
            {
                isCorrectObjectInside = true;
                obj.isPlacedCorrectly = true;

                Debug.Log("Correct object placed!");

                onCorrectPlacement.Invoke();
            }
        }
        // Wrong object
        else
        {
            Debug.Log("Wrong object.");

            onWrongPlacement.Invoke();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        PlaceableObject obj = other.GetComponent<PlaceableObject>();

        if (obj == null)
            return;

        if (obj.objectID == placementID)
        {
            isCorrectObjectInside = false;
            obj.isPlacedCorrectly = false;

            Debug.Log("Correct object removed.");

            onObjectRemoved.Invoke();
        }
    }
}