using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static bool GameIsOver;

    public GameObject gameOverUI;
    public GameObject completeLevelUI;

    public string nextLevel = "DEMOLEVELCOPY";
    public int levelToUnlock = 2;

    public SceneFader sceneFader;

    public AudioManager audioManager;

    void Start()
    {
        GameIsOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameIsOver)
            return;

        if(Input.GetKeyDown("e"))
        {
            EndGame();
        }

        if (PlayerStats.Lives <= 0)
        {
            EndGame();
        }
    }

    void EndGame()
    {
        GameIsOver = true;

        gameOverUI.SetActive(true);
        audioManager.GameOverMusicMusic();
    }

    public void WinLevel ()
    {
        GameIsOver = true;
        completeLevelUI.SetActive(true);
    }
}
