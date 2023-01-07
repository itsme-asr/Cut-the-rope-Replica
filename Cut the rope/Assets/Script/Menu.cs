using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField] AudioSource playAudio;
    public void exitGame()
    {
        Debug.Log("Namaste World");
        playAudio.Play();
        Application.Quit();
    }

    public void nextLevel()
    {
        playAudio.Play();
        Invoke("Play", 1);
    }

    public void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }



    public void playStartAudio()
    {
        playAudio.Play();
    }
}
