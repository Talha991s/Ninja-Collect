using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public GameObject pauseui;
    private void Awake()
    {
        if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
        }
    }
    private void Update()
    {
        if(Input.GetKey(KeyCode.P))
        {
            ToggleGamePause();
            pauseui.SetActive(true);
        }
    }
    //Toggles game pause
    public void ToggleGamePause()
    {

        if (Time.timeScale == 0)
        {
            pauseui.SetActive(false);
            Time.timeScale = 1;
            return;
        }

        Time.timeScale = 0;
    }

    //Sets the whether the game is paused or not.
    public void SetGamePause(bool _set)
    {
        if (_set)
        {
            //FindObjectOfType<SoundManager>().Play("resume");
            Time.timeScale = 0;
            return;
        }
        Time.timeScale = 1;
        //FindObjectOfType<SoundManager>().Play("resume");
    }

    //Sets the timescale manually
    public void SetTimeScale(float _timeScale)
    {
        Time.timeScale = _timeScale;
    }

    //Returns whether or not the game is paused.
    public bool IsGamePaused()
    {
        if (Time.timeScale == 0)
        {
            return true;
        }
        return false;
    }
}
