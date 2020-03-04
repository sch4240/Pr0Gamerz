using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LifeSystem : MonoBehaviour
{
  public int lives;

  // Start is called before the first frame update
  void Start()
  {
      lives = 3;
  }

  public void decreaseLives(){
    lives--;
    if(lives == 0){
      SceneManager.LoadScene("EndScene");
    }
  }

  public int getLives(){
    return lives;
  }
}
