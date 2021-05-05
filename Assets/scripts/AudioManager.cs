using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    public AudioSource BGM;

    public AudioClip gameOverMusic;

    public void GameOverMusicMusic()
    {
        BGM.Stop();
        BGM.clip = gameOverMusic;
        BGM.Play();
    }
}
