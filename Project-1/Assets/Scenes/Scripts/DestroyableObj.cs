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
    // variable for object health
    public float health;
    public float maxHealth;


    // Start is called before the first frame update
    void Start()
    {
        // initialize the private vars
        startColor = GetComponent<Renderer>().material.color;
        health = maxHealth;
        int numDestroyed = GameObject.Find("Manager").GetComponent<Manager>().numDestroyed;
        maxHealth = (numDestroyed * 5) + 15;
        health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        // delete this object if its health has reached zero
       if(health == 0)
        {
            GameObject.Find("Manager").GetComponent<Manager>().numDestroyed++;
            Destroy(gameObject);

            return;
        }
       // update the color based on the current health of the obj
        GetComponent<Renderer>().material.color = Color.Lerp(damagedColor, startColor, (float)health/maxHealth);
    }

    // handler for clicking on the object, which will deprecate its health
    void OnMouseDown()
    {
        health--;
        GameObject bar = GameObject.Find("Slider");
        bar.GetComponent<Slider>().value = health / maxHealth;
        Debug.Log(health);
    }
}
