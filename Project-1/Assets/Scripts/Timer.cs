using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float seconds;
    public float startTime = 20;
    public bool timerTick;
    // Start is called before the first frame update
    void Start()
    {
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
            GameObject.Find("TimerText").GetComponent<Text>().text = ""+seconds;
            if (seconds <= 0)
            {
                timerTick = false;
                //transition to store screen
                //SceneManager.UnloadScene("mainGame");
                SceneManager.LoadScene("Shop");
                //SceneManager.MoveGameObjectToScene(GameObject.Find("ItemSystem"), SceneManager.GetSceneByName("Shop"));
            }
        }
    }
}
