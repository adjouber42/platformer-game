using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bullet : MonoBehaviour
{
    private Scene currentLevel;
    
    void Start()
    {
        currentLevel = SceneManager.GetActiveScene();
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.layer == transform.gameObject.layer)
        {
            print("Game Over");
            SceneManager.LoadScene(currentLevel.buildIndex);
        }
    }
}
