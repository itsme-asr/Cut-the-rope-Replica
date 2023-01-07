using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Death : MonoBehaviour
{
    private Animator anim;
    [SerializeField] private AudioSource deathSound;
    void Start()
    {
        anim = GetComponent<Animator>();

    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Trap"))
        {
            Die();
            restartLevel();
        }
    }

    private void Die()
    {
        anim.SetBool("Death", true);
    }

    private void restartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
}
