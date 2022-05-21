using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public GameObject pauseButton;
    public bool paused = false;

    public void pausing()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
            pauseButton.SetActive(true);
            paused = true;
        }
        else
        {
            Time.timeScale = 1;
            pauseButton.SetActive(true);
            paused = false;
        }
    }

    public void unPause()
    {
        Time.timeScale = 1;
        pauseButton.SetActive(true);
        paused = false;
    }
}
