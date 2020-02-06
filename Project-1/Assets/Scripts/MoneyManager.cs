using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//script for tracking player's money

public class MoneyManager : MonoBehaviour
{
    public int money = 0;

    public void addMoney(){
      money += 5;
      Debug.Log("Money: " +money);
      GameObject.Find("MoneyText").GetComponent<Text>().text = "Money: "+money;
    }

    public void addMoreMoney(){
      money += 10;
      Debug.Log("Money: "+money);
      GameObject.Find("MoneyText").GetComponent<Text>().text = "Money: "+money;
    }

    void Awake()
    {
      DontDestroyOnLoad(gameObject);
    }

    // void Start(){
    //   GameObject.Find("MoneyText").GetComponent<Text>().text = "Money: "+money;
    // }

    // void Update()
    // {
    //     GameObject.Find("MoneyText").GetComponent<Text>().text = "Money: "+money;
    // }
}
