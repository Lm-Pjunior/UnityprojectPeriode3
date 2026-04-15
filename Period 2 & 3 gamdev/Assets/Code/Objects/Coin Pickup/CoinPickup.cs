
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinPickup : MonoBehaviour
{

    //ADD A NEW SCRIPT YA BIG OOF basicly the bug is that the coins get deleted and thus the points too :P
    [SerializeField ]private CoinCounter _showCoinCount;
    [SerializeField] private GameObject _GameObjectName;

    private void Start()
    {
        _showCoinCount = FindAnyObjectByType<CoinCounter>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {//this is for a trigger
        if (collision.tag == "Player")
        {
            
            Destroy(_GameObjectName);
            _showCoinCount.countCoin();
        }
    }

    
}
