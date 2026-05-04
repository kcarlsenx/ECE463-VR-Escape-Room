using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseTestButton : MonoBehaviour
{
    public PasscodeSystem passcodeSystem;
    public int digit;

    private void OnMouseDown()
    {
        passcodeSystem.EnterDigit(digit);
    }
}