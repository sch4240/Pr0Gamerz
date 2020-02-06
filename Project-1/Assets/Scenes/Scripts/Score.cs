using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    GameObject manager;
    // Start is called before the first frame update
    void Start()
    {
        manager = GameObject.Find("Manager");
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Text>().text = "Score: "+manager.GetComponent<Manager>().numDestroyed + "\n" + "High Score: " + manager.GetComponent<Manager>().highScore;
    }
}
