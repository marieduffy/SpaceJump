using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetScene : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D fallCollider)
    {
        Scene scene = SceneManager.GetActiveScene();

        if (fallCollider.CompareTag("Player"))
        {
            SceneManager.LoadScene(scene.name);
            Debug.Log("Scene loaded");
        }
    }
}
