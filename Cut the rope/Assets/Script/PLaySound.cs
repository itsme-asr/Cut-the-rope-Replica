using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLaySound : MonoBehaviour
{
    public AudioSource playAudio;

    public void playStartAudio()
    {
        playAudio.Play();
    }


}
