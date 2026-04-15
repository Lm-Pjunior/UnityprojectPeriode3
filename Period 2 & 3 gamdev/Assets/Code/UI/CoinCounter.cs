using System.Collections.Generic;
using TMPro;
using UnityEngine;
public class CoinCounter : MonoBehaviour
{
    [SerializeField] private GameObject _pointText;
    private int _coinPickupIndex = 0;
  
    public void countCoin()
    {
        _coinPickupIndex++;
        _pointText.GetComponent<TextMeshProUGUI>().text = $"Points: {_coinPickupIndex}";
        Debug.Log("CoinUP!");
    }


}
