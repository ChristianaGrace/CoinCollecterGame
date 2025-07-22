using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CoinManager : MonoBehaviour
{
    public int coinCount;
    public TMP_Text coinText;
    // Start is called before the first frame update
    void Start()
    {
        if(coinText != null){
            coinText.text = "0";
        }

    }

    // Update is called once per frame
    void Update()
    {
         if (coinText != null)
        {
            coinText.text = "Coin Count: " + coinCount.ToString();
        }
    }
}
