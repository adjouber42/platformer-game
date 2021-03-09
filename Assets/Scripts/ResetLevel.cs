using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetLevel : MonoBehaviour
{
    private Scene currentLevel;

    void Start()
    {
        currentLevel = SceneManager.GetActiveScene();
    }
    
    void Update()
    {
        if (Input.GetKeyDown("r"))
            SceneManager.LoadScene(currentLevel.buildIndex);
    }
}
