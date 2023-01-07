using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class touchEny : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Candy")
        {
            Destroy(col.gameObject);
            restartLevel();
        }
    }

    private void restartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }


}
