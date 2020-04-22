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

    public void decreaseLives()
    {
        lives--;
        if (lives == 0)
        {
            // save the name of this scene to player preferences so the scene switcher script can refer to it when the start over button is hit
            PlayerPrefs.SetString("previousScene", SceneManager.GetActiveScene().name);
            SceneManager.LoadScene("EndScene");
        }
    }

    public int getLives()
    {
        return lives;
    }
}
