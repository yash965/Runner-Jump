using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class CoinData { 

    public int coins;

    public CoinData ()
    {
        coins = CoinSystem.coins;
    }
}
