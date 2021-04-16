using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveCurrentLevel : MonoBehaviour
{
    public void SaveLevel()
    {
        PlayerManager._instance.savedSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene("WelcomePage");
    }
}
