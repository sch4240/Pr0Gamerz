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
    }

    public void addMoreMoney(){
      money += 10;
    }

    void Awake()
    {
      DontDestroyOnLoad(gameObject);
    }
}
