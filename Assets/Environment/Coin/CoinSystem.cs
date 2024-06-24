using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinSystem : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI CoinNumText;

    public static int coins;
    
    public void AddCoin()
    {
        coins++;
        CoinNumText.text = coins.ToString();
    }
}
