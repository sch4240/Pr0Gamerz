using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShopManager : MonoBehaviour
{
    public void onExtraDamagePurchase(){
      if(GameObject.Find("MoneySystem").GetComponent<MoneyManager>().money >= 20){
        GameObject.Find("MoneySystem").GetComponent<MoneyManager>().money -= 20;
        GameObject.Find("ItemSystem").GetComponent<ItemManager>().extraDamage = true;
      }
    }

    public void onExtraMoneyPurchase(){
      if(GameObject.Find("MoneySystem").GetComponent<MoneyManager>().money >= 15){
        GameObject.Find("MoneySystem").GetComponent<MoneyManager>().money -= 15;
        GameObject.Find("ItemSystem").GetComponent<ItemManager>().extraMoney = true;
      }
    }

    public void onExtraTimePurchase(){
      if(GameObject.Find("MoneySystem").GetComponent<MoneyManager>().money >= 30){
        GameObject.Find("MoneySystem").GetComponent<MoneyManager>().money -= 30;
        GameObject.Find("ItemSystem").GetComponent<ItemManager>().extraTime = true;
      }
    }

    public void backToGame(){
      SceneManager.LoadScene("mainGame");
    }

    public void backToTitle(){
      SceneManager.LoadScene("Title");
    }
}
