using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCoin: MonoBehaviour
{
    private CoinSystem addCoin;

    void Start()
    {
        addCoin = GameObject.FindGameObjectWithTag("CoinSystem").GetComponent<CoinSystem>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.transform.tag == "Player")
        {
            addCoin.AddCoin();
            Destroy(gameObject);
        }
    }

}
