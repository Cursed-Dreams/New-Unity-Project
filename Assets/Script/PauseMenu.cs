using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseUI;
    bool isPaused = false;

    private void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            TogglePause();
        }
    }
    public void TogglePause()
    {
        if (isPaused)
        {
            //unpause
            Time.timeScale = 1.0f;

            //Hides the button when the game is unpaused
            pauseUI.SetActive(false);

            //When ispaused is true, this line will set it to false
        }
        else
        {
            //pause
            Time.timeScale = 0f;

            //Shows the button when the game is paused
            pauseUI.SetActive(true);

            //When ispaused is false, this line will set it to true
        }

        //Sets ispaused to the opposite of what it is right now
        isPaused = !isPaused;
    }

    public void Quit()
    {
        Application.Quit();
    }
}
