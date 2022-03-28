using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    // [SerializeField] private float healthValue;

    private void OnTriggerEnter2D(Collider2D col)
    {
           Coincounter.coinAmount += 1;
            Destroy (gameObject);
    }
}