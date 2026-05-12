using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlchemyBurnerInteract : MonoBehaviour
{
    public AlchemyCandleTrigger candleTrigger;

    public void TurnOffFixture()
    {
        if (candleTrigger != null)
            candleTrigger.TurnOff();
    }
}