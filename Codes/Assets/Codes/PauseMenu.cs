using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PauseMenu : MonoBehaviour
{
    public static bool isGamePaused = false;
    public static bool isGameOver = false;
    [SerializeField] GameObject pauseMenu;
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            
                if (isGamePaused)
                {
                    ResumeGame();
                }
                else
                {
                    PauseGame();
                }
            
        }
        void ResumeGame()
        {
        if (!isGameOver)
        {
            pauseMenu.SetActive(false);
            Time.timeScale = 1f;
            isGamePaused = false;
            }
            else
            {

            }
        }
        void PauseGame()
        {
            if (!isGameOver)
            {
            pauseMenu.SetActive(true);
            Time.timeScale = 0f;
            isGamePaused = true;
            }
            else
            {

            }
        }
    }
        public void QuitGame()
        {
            Application.Quit();
        }
}
