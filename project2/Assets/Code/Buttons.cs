using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public GameObject StartButton;
    public GameObject QuitButton;
    public GameObject HowToButton;
    public GameObject NextButton;
    //public GameObject pauseMenu;
    //public GameObject resumeButton;

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

    public void quitBtn()
    {
#if !UNITY_WEBGL
        Application.Quit();
#endif
#if UNITY_WEBGL
        SceneManager.LoadScene("TitleScreen");
#endif
    }

    public void howToBtn()
    {
        SceneManager.LoadScene("HowToScene");
    }

    public void nextBtn()
    {
        SceneManager.LoadScene("HowTo2Scene");
    }

    //public void pauseBtn()
    //{
    //    //pauseMenu.SetActive(true);
    //    Time.timeScale = 0f;
    //}

    //public void resumeBtn()
    //{
    //    //pauseMenu.SetActive(false);
    //    Time.timeScale = 1.0f;
    //}

    void Update()
    {
#if !UNITY_WEBGL
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
#endif

#if UNITY_WEBGL
        if (Input.GetKeyDown(KeyCode.Escape)) {
            SceneManager.LoadScene("TitleScreen");
        }
#endif
    }
}
