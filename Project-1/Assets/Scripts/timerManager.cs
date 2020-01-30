using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timerManager : MonoBehaviour
{
    public GameObject bar;
    public float maxHP;
    public float currentHP;

    public GameObject timeObj;

    public float time = 0.0f;
    public float totalTime = 60.0f;

    public GameObject manager;
    public GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        manager = GameObject.Find("Manager");

        maxHP = manager.GetComponent<Manager>().targetObj.GetComponent<DestroyableObj>().maxHealth;
        currentHP = manager.GetComponent<Manager>().targetObj.GetComponent<DestroyableObj>().health;

    }

    // Update is called once per frame
    void Update()
    {
        // maxHP = manager.GetComponent<Manager>().targetObj.GetComponent<DestroyableObj>().maxHealth;
        // currentHP = manager.GetComponent<Manager>().targetObj.GetComponent<DestroyableObj>().health;

        // bar.GetComponent<Slider>().value = currentHP / maxHP;
        // Debug.Log(currentHP);

        time += Time.deltaTime;
        int seconds = (int)time % 60;
        float timeRemaining = totalTime - seconds;
        timeObj.GetComponent<Text>().text = timeRemaining.ToString();

    }
}
