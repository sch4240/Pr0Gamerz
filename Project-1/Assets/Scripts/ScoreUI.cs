using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
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
        GameObject.Find("ScoreText").GetComponent<Text>().text = "Score: "+manager.GetComponent<Manager>().numDestroyed;
    }
}
