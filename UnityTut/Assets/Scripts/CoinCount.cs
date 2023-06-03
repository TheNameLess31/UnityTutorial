using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCount : MonoBehaviour
{
    public int numberOfCoins;
    public Text numberOfCoinsText;
    // Start is called before the first frame update
    void Start()
    {
        numberOfCoins = 0;
        numberOfCoinsText.text = numberOfCoins.ToString();
    }

    public void AddCoin()
    {
        numberOfCoins++;
        numberOfCoinsText.text = numberOfCoins.ToString();
    }

}
