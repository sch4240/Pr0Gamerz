using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    private Vector3 position;
    public string type;
    ScoringSystem scoreSys;

    // Update is called once per frame
    void Update()
    {
        position = this.transform.position;
        position.y -= Time.deltaTime * 2;
        this.transform.position = position;
        scoreSys = GameObject.Find("ScoringSystem").GetComponent<ScoringSystem>();
        //Debug.Log("Position: " + position.y);
        //Debug.Log("transform: " + this.transform.position.y);
    }

    public bool checkType(string swipe)
    {
        if(position.y < 5)
        {
            if (swipe == type)
            {
                scoreSys.increaseScore();
                return true;
            }
            else
            {
                return false;
            }
        }
        return false;
        
    }
}
