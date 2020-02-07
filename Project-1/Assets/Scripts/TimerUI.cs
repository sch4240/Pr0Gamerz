using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerUI : MonoBehaviour
{
    public float seconds;
    public float startTime = 20;
    public bool timerTick;
    // Start is called before the first frame update
    void Start()
    {
        // check for extra time upgrade, then set up timer for gameplay and display
        timerTick = true;
        if(GameObject.Find("ItemSystem").GetComponent<ItemManager>().extraTime){
          seconds = startTime + 10;
        } else {
          seconds = startTime;
        }
        GameObject.Find("TimerText").GetComponent<Text>().text = "" + seconds;
    }

    // Update is called once per frame
    void Update()
    {
        if (timerTick != false)
        {
            seconds -= Time.deltaTime;
            gameObject.GetComponent<Text>().text = ""+seconds;
            if (seconds <= 0) // go to shop when game ends
            {
                timerTick = false;
                SceneManager.LoadScene("Shop");
            }
        }
    }
}
