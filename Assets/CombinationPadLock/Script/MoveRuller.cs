// Script by Marcelli Michele
// Modified by Kyle Carlsen

using System.Collections.Generic;
using UnityEngine;

public class MoveRuller : MonoBehaviour
{
    PadLockPassword _lockPassword;

    [HideInInspector]
    public List<GameObject> _rullers = new List<GameObject>();

    [HideInInspector]
    public int[] _numberArray = { 0, 0, 0, 0 };

    public float rotationStep = 36f;

    private void Awake()
    {
        _lockPassword = FindObjectOfType<PadLockPassword>();

        _rullers.Add(GameObject.Find("Ruller1"));
        _rullers.Add(GameObject.Find("Ruller2"));
        _rullers.Add(GameObject.Find("Ruller3"));
        _rullers.Add(GameObject.Find("Ruller4"));

        foreach (GameObject r in _rullers)
        {
            r.transform.Rotate(-144, 0, 0, Space.Self);
        }
    }

    public void RotateRuller(int index)
    {
        if (index < 0 || index >= _rullers.Count)
            return;

        _rullers[index].transform.Rotate(
            -rotationStep,
            0,
            0,
            Space.Self
        );

        _numberArray[index] += 1;

        if (_numberArray[index] > 9)
        {
            _numberArray[index] = 0;
        }

        _lockPassword.Password();
    }
}
