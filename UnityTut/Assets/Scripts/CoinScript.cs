using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    public CoinCount coinCounter;

    public void OnTriggerEnter(Collider collider)
    {
        coinCounter.AddCoin();
        Destroy(gameObject);
    }
}
