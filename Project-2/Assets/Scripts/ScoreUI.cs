using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{
    public int scoreToDisplay;

    // Update is called once per frame
    void Update()
    {
        scoreToDisplay = GameObject.Find("ScoringSystem").GetComponent<ScoringSystem>().getScore();
        gameObject.GetComponent<Text>().text = "SCORE: " + scoreToDisplay;
    }
}
