﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class timerManager : MonoBehaviour
{
    public GameObject bar;
    public float maxHP;
    public float currentHP;

    public GameObject timeObj;

    public float time = 30.0f;
    public float totalTime = 30.0f;

    public GameObject manager;
    public GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        manager = GameObject.Find("Manager");

/*        maxHP = manager.GetComponent<Manager>().target.GetComponent<DestroyableObj>().maxHealth;
        currentHP = manager.GetComponent<Manager>().targetObj.GetComponent<DestroyableObj>().health;*/

    }

    // Update is called once per frame
    void Update()
    {
        // maxHP = manager.GetComponent<Manager>().targetObj.GetComponent<DestroyableObj>().maxHealth;
        // currentHP = manager.GetComponent<Manager>().targetObj.GetComponent<DestroyableObj>().health;

        // bar.GetComponent<Slider>().value = currentHP / maxHP;
        // Debug.Log(currentHP);

        time = time - (1 * Time.deltaTime);
        if(time <= 0)
        {
            if(manager.GetComponent<Manager>().numDestroyed > manager.GetComponent<Manager>().highScore)
            {
                manager.GetComponent<Manager>().SaveHighScore(manager.GetComponent<Manager>().numDestroyed);
                Debug.Log("new high score");
            }
            SceneManager.LoadScene("Title");
        }
        // int seconds = (int)time % 60;
        // float timeRemaining = totalTime - seconds;
        timeObj.GetComponent<Slider>().value = time;

    }
}
