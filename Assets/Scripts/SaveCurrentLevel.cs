﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveCurrentLevel : MonoBehaviour
{
    public void SaveLevel()
    {
        PlayerManager._instance.savedSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene("WelcomePage");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
