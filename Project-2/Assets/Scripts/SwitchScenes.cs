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

    public void GoToEndScene()
    {
        SceneManager.LoadScene("EndScene");
    }
}
