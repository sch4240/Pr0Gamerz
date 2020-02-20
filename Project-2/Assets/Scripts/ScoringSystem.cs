using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoringSystem : MonoBehaviour
{
    private int score;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    public void increaseScore(){
      score++;
    }

    public int getScore(){
      return score;
    }
}
