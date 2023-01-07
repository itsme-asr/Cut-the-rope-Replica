using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class touchEny : MonoBehaviour
{
    [SerializeField] private AudioSource deathSound;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Candy")
        {
            Destroy(col.gameObject);
            deathSound.Play();
            Invoke("restartLevel", 2);
        }
    }

    public void restartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }


}
