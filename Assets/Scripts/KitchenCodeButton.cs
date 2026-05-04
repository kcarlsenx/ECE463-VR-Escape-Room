using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KitchenCodeButton : MonoBehaviour
{
    public KitchenComboLock kitchenComboLock; 
    public int digitIndex;

    private void OnMouseDown()
    {
        if (kitchenComboLock != null)
        {
            kitchenComboLock.IncrementDigit(digitIndex);
        }
    }
}