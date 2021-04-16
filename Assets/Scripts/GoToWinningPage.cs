using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToWinningPage : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log("hello");
        if (collider.CompareTag("Rocket"))
        {
            Debug.Log("made it here");
            SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
