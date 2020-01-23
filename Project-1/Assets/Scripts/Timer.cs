using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float seconds;
    public float startTime = 20;
    public bool timerTick;
    // Start is called before the first frame update
    void Start()
    {
        timerTick = true;
        seconds = startTime;
        GetComponent<Text>().text = "" + seconds;
    }

    // Update is called once per frame
    void Update()
    {
        if (timerTick != false)
        {
            seconds -= Time.deltaTime;
            GetComponent<Text>().text = ""+seconds;
            if (seconds <= 0)
            {
                timerTick = false;
            }
        }
    }
}
