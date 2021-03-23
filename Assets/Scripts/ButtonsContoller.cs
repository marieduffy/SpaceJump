using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonsContoller : MonoBehaviour
{
    public void LoadCredits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void LoadWelcomePage()
    {
        SceneManager.LoadScene("WelcomePage");
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Level1");
    }
}
