using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonsContoller : MonoBehaviour
{
    public TMP_Text TextField;
    public GameObject button;

    public void Start()
    {
        //button = GameObject.Find("ProceedButton");
        button.SetActive(false);
    }
    public void LoadCredits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void LoadWelcomePage()
    {
        SceneManager.LoadScene("WelcomePage");
    }

    public void PlayNewGame()
    {
        if (PlayerManager._instance.savedSceneIndex <= 1)
        {
            SceneManager.LoadScene("Level1");
        }
        else
        {
            TextField.text = "You have a game in progress. Do you still want" +
                             "to start a new game?";
            button.SetActive(true);
        }
    }

    public void NewGame()
    {
        SceneManager.LoadScene("Level1");
    }

    public void ResumeGame()
    {
        if (PlayerManager._instance.savedSceneIndex > 1)
        {
            SceneManager.LoadScene(PlayerManager._instance.savedSceneIndex);
        }
        else
        {
            TextField.text = "You do not have a game saved";
        }
    }

    public void MainMenuSave()
    {
        PlayerManager._instance.savedSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene("WelcomePage");
    }
}
