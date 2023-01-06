using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pointsCollector : MonoBehaviour
{
    private int point = 0;
    [SerializeField] private Text pointsText;
    [SerializeField] private AudioSource pointAudio;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Point"))
        {
            Destroy(col.gameObject);
            pointAudio.Play();
            point++;

            pointsText.text = "Point = " + point;
            Debug.Log(pointsText);

        }

    }
}
