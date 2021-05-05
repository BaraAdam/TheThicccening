using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public string levelToLoad = "DEMOLEVEL";

    public SceneFader sceneFader;

    public GameObject tutorial;

    public void Play ()
    {
        sceneFader.FadeTo(levelToLoad);
    }

    public void Quit ()
    {
        Debug.Log("exiting...");
        Application.Quit();
    }

    public void HowToPlay()
    {
        tutorial.SetActive(true);
    }

    public void Back()
    {
        tutorial.SetActive(false);
    }
}
