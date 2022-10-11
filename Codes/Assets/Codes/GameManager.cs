using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public GameObject GameOverCanvas;
    [SerializeField] private AudioSource BackGroundMusic;

    public void Start()
    {
        if (BackgroundMusic.isGameMuted == false)
        { 
            BackGroundMusic.Play();
            Time.timeScale = 1;
        }
        else
        {
            BackGroundMusic.Stop();
            Time.timeScale = 1;
        }
    }
    public void GameOver()
    {
        if (BackgroundMusic.isGameMuted == false)
        {
        
        PauseMenu.isGameOver = true;
        GameOverCanvas.SetActive(true);
        Time.timeScale = 0;
        }
        else
        {
            BackGroundMusic.Stop();
            PauseMenu.isGameOver = true;
            GameOverCanvas.SetActive(true);
            Time.timeScale = 0;
        }
    }
    public void Replay()
    {
        if(BackGroundMusic.isPlaying == false)
        { 
        SceneManager.LoadScene(0);
        PauseMenu.isGameOver = false;
        BackGroundMusic.Stop();
        }
        else
        {
            SceneManager.LoadScene(0);
            PauseMenu.isGameOver = false;
            BackGroundMusic.Play();
        }
    }
}
