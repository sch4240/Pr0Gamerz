using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyableObj : MonoBehaviour
{
    // variable for object health
    public int health;
    public int maxHealth;

    // Start is called before the first frame update
    void Start()
    {
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
            Destroy(gameObject);
        } 
    }

    // handler for clicking on the object, which will deprecate its health
    void OnMouseDown()
    {
        health--;
        Debug.Log(health);
    }
}
