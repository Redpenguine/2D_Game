using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool IsPaused = false;
    public GameObject PauseMenuUI;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (IsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    void Resume()
    {
        Time.timeScale = 1;
        PauseMenuUI.SetActive(false);
        IsPaused = false;
    }

    void Pause()
    {
        Time.timeScale = 0;
        PauseMenuUI.SetActive(true);
        IsPaused = true;
    }

    public void ResumeGame()
    {
        Resume();
    }

    public void ReplayGame()
    { 
        
    }

    public void ToMainMenu()
    {
        
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
