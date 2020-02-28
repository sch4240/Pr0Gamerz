using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoringSystem : MonoBehaviour
{
    private int score;
    private int combo;
    private int multiplier;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        combo = 0;
    }

    public void increaseScore(){
      score++;
      if(combo % 10 == 0){
        multiplier = combo / 10;
      }
      score *= multiplier;
    }

    public int getScore(){
      return score;
    }

    public void resetCombo(){
      combo = 0;
    }

    public void increaseCombo(){
      combo++;
    }
}
