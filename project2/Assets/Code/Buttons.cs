using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public GameObject StartButton;
    public GameObject QuitButton;
    public GameObject HowToButton;
    //public GameObject pauseMenu;

    public void startBtn()
    {
        if (SceneManager.GetActiveScene().name == "TitleScreen")
        {
            SceneManager.LoadScene("GameScene");
        }
        else
        {
            SceneManager.LoadScene("TitleScreen");
        }
    }

    public void quigBtn()
    {
#if !UNITY_WEBGL
        Application.Quit();
#endif
#if UNITY_WEBGL
        SceneManager.LoadScene("StartGame");
#endif
    }

    public void howToBtn()
    {
        SceneManager.LoadScene("HowToScene");
    }

    //void pauseBtn()
    //{
    //    pauseMenu.SetActive(true);
    //    Time.timeScale = 0f;
    //}

    //void resumeBtn()
    //{
    //    pauseMenu.SetActive(false);
    //    Time.timeScale = 1.0f;
    //}
}
