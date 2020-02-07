using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ShopManager : MonoBehaviour
{
    // use start to preset button status if upgrades have already been purchased
    public void Start()
    {
        if (GameObject.Find("ItemSystem").GetComponent<ItemManager>().extraDamage == true)
        {
            GameObject.Find("DamagePurchaseButton").GetComponentInChildren<Text>().text = "- SOLD! -";
            GameObject.Find("DamagePurchaseButton").GetComponent<Button>().interactable = false;
        }
        if (GameObject.Find("ItemSystem").GetComponent<ItemManager>().extraMoney == true)
        {
            GameObject.Find("MoneyPurchaseButton").GetComponentInChildren<Text>().text = "- SOLD! -";
            GameObject.Find("MoneyPurchaseButton").GetComponent<Button>().interactable = false;
        }
        if (GameObject.Find("ItemSystem").GetComponent<ItemManager>().extraTime == true)
        {
            GameObject.Find("TimePurchaseButton").GetComponentInChildren<Text>().text = "- SOLD! -";
            GameObject.Find("TimePurchaseButton").GetComponent<Button>().interactable = false;
        }
    }

    // handle the damage upgrade getting bought
    public void onExtraDamagePurchase()
    {
        if (GameObject.Find("MoneySystem").GetComponent<MoneyManager>().money >= 20)
        {
            GameObject.Find("MoneySystem").GetComponent<MoneyManager>().money -= 20;
            GameObject.Find("ItemSystem").GetComponent<ItemManager>().extraDamage = true;
            GameObject.Find("DamagePurchaseButton").GetComponentInChildren<Text>().text = "- SOLD! -";
            GameObject.Find("DamagePurchaseButton").GetComponent<Button>().interactable = false;
        }
    }

    // handle the money upgrade getting bought
    public void onExtraMoneyPurchase()
    {
        if (GameObject.Find("MoneySystem").GetComponent<MoneyManager>().money >= 15)
        {
            GameObject.Find("MoneySystem").GetComponent<MoneyManager>().money -= 15;
            GameObject.Find("ItemSystem").GetComponent<ItemManager>().extraMoney = true;
            Debug.Log("Money Purchase Button name: " + GameObject.Find("MoneyPurchaseButton").name);
            GameObject.Find("MoneyPurchaseButton").GetComponentInChildren<Text>().text = "- SOLD! -";
            GameObject.Find("MoneyPurchaseButton").GetComponent<Button>().interactable = false;
        }
    }

    // handle the time upgrade getting bought
    public void onExtraTimePurchase()
    {
        if (GameObject.Find("MoneySystem").GetComponent<MoneyManager>().money >= 30)
        {
            GameObject.Find("MoneySystem").GetComponent<MoneyManager>().money -= 30;
            GameObject.Find("ItemSystem").GetComponent<ItemManager>().extraTime = true;
            GameObject.Find("TimePurchaseButton").GetComponentInChildren<Text>().text = "- SOLD! -";
            GameObject.Find("TimePurchaseButton").GetComponent<Button>().interactable = false;
        }
    }

    // helper function for loading the main game
    public void backToGame()
    {
        SceneManager.LoadScene("mainGame");
    }

    // helper function for loading the title screen
    public void backToTitle()
    {
        SceneManager.LoadScene("Title");
    }
}
