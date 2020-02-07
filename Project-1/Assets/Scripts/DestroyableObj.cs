using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DestroyableObj : MonoBehaviour
{
    // variable for object health at start of game as well as private tracking var
    public int startHealth;
    int currentHealth;
    // color variables to lerp between
    Color startColor;
    [SerializeField]
    Color damagedColor = Color.red;
    // variables for object health
    public float health;
    public float maxHealth;
    // GO for item system to check when interacting with this for special cases
    GameObject itemSystem;


    // Start is called before the first frame update
    void Start()
    {
        // initialize the private vars
        startColor = GetComponent<Renderer>().material.color;
        health = maxHealth;
        int numDestroyed = GameObject.Find("Manager").GetComponent<Manager>().numDestroyed;
        maxHealth = (numDestroyed * 5) + 15;
        health = maxHealth;
        itemSystem = GameObject.Find("ItemSystem");
    }

    // Update is called once per frame
    void Update()
    {
        // delete this object if its health has reached zero
       if(health <= 0)
        {
            GameObject.Find("Manager").GetComponent<Manager>().numDestroyed++;
            if (GameObject.Find("ItemSystem").GetComponent<ItemManager>().extraMoney)
            {
                GameObject.Find("MoneySystem").GetComponent<MoneyManager>().addMoreMoney();
            }
            else
            {
                GameObject.Find("MoneySystem").GetComponent<MoneyManager>().addMoney();
            }
            Destroy(gameObject);
            return;
        }
       // update the color based on the current health of the obj
        GetComponent<Renderer>().material.color = Color.Lerp(damagedColor, startColor, (float)health/maxHealth);
    }

    // handler for clicking on the object, which will deprecate its health and increase player's money
    void OnMouseDown()
    {
        if(GameObject.Find("ItemSystem").GetComponent<ItemManager>().extraDamage){
          health -= 2;
        }else{
          health--;
        }
        Debug.Log(health);
    }
}
