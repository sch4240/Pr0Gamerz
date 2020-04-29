using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

// Helper function for switching between scenes (to be attached to button OnClick events)
public class SwitchScenes : MonoBehaviour
{
    public void GoToStartScene()
    {
        SceneManager.LoadScene("StartScene");
    }

    public void GoToMainScene()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void GoToPreviousScene()
    {
        // MAKE SURE THIS ONLY GETS CALLED AFTER THIS STRING HAS BEEN SET (currently gets set in LifeSystem & AudioManager)
        SceneManager.LoadScene(PlayerPrefs.GetString("previousScene"));
    }

    public void GoToEndScene()
    {
        SceneManager.LoadScene("EndScene");
    }

    public void GoToLevelSelectScene()
    {
        SceneManager.LoadScene("LevelSelect");
    }

    public void GoToSong1Scene()
    {
        SceneManager.LoadScene("Song1");
    }

    public void GoToSong2Scene()
    {
        SceneManager.LoadScene("Song2");
    }

    public void GoToSong3Scene()
    {
        SceneManager.LoadScene("Song3");
    }
}
