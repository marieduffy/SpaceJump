using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScenes : MonoBehaviour
{
    
    public void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Player"))
        {
            SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex + 1);
            //Invoke("LoadNextScene", 1.0f);
        }
    }

    private void LoadNextScene()
    {
        
    }
}
