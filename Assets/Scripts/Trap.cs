using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trap : MonoBehaviour
{
    private Scene currentLevel;

    void Start()
    {
        currentLevel = SceneManager.GetActiveScene();
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        print("Game Over");
        SceneManager.LoadScene(currentLevel.buildIndex);
    }
}
