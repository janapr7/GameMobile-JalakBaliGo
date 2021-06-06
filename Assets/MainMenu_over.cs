using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu_over : MonoBehaviour
{
    public void playGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-1);
    }

    public void quitGame()
    {
        // Application.Quit();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-2);
    }
}
