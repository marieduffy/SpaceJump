using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    public Animator animator;
    public GameObject astronaut;
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            animator.SetBool("RocketReached", true);
            astronaut.SetActive(false);
            Invoke("LoadWinningScene", 1.0f);
        }
    }

    public void LoadWinningScene()
    {
        SceneManager.LoadScene("WinningPage");
    }
}
