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
        multiplier = 1;
    }

    public void increaseScore(){
      // score++;
      combo++;
      //if(combo % 10 == 0){
            // multiplier = combo / 10;
            if(combo < 8)
        {
            multiplier *= 2;

        }
        if (combo != 0)
        {
           score += multiplier;
        }
      // }
     
      
    }

    public int getScore(){
      return score;
    }

    public int getCombo()
    {
        return combo;
    }

    public void resetCombo(){
      combo = 0;
        multiplier = 1;
    }

    public void increaseCombo(){
      combo++;
    }
}
