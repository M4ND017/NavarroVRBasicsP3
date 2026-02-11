using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandleLogic : MonoBehaviour
{
    public GameObject candleFlame;
    private void OnTriggerEnter(Collider other)
    {
        // Does the thing touching us have the "Flame" tag?
        if (other.CompareTag("Flame"))
        {
            candleFlame.SetActive(true); // Light the candle!
        }
    }
}
