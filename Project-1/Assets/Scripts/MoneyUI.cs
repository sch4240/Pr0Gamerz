using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyUI : MonoBehaviour
{
    int moneyToDisplay;

    // Update is called once per frame
    void Update()
    {
        moneyToDisplay = GameObject.Find("MoneySystem").GetComponent<MoneyManager>().money;
        gameObject.GetComponent<Text>().text = "Money: " + moneyToDisplay;
    }
}
