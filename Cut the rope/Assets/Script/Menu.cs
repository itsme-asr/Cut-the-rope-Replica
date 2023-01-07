using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void exitGame()
    {
        Debug.Log("Namaste World");
        Application.Quit();
    }

    public void nextLevel()
    {
        Invoke("Play", 1);
    }

    public void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
