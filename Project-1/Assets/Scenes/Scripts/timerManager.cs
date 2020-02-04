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

    public GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        DestroyableObj destroyObj = GameObject.Find("Manager").GetComponent<Manager>().objects[0].GetComponent<DestroyableObj>();
        maxHP = destroyObj.maxHealth;
        currentHP = destroyObj.health;

    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        int seconds = (int)time % 60;
        float timeRemaining = totalTime - seconds;
        timeObj.GetComponent<Text>().text = timeRemaining.ToString();

    }
}
