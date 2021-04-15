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
    private int sceneIndex;

    public void Start()
    {
        //button = GameObject.Find("ProceedButton");
        button.SetActive(false);
    }
    public void LoadCredits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void PlayNewGame()
    {
        sceneIndex = PlayerManager._instance.savedSceneIndex;
        if (sceneIndex <= 1 || sceneIndex == 6)
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
        sceneIndex = PlayerManager._instance.savedSceneIndex;
        if (sceneIndex > 1 && sceneIndex != 6)
        {
            SceneManager.LoadScene(sceneIndex);
        }
        else
        {
            TextField.text = "You do not have a game saved";
        }
    }

    
}
