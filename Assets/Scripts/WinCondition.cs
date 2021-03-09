using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinCondition : MonoBehaviour
{
    private GameObject   player_1;
    private GameObject   player_2;
    private GameObject   player_3;
    private Scene currentLevel;

    void Start()
    {
        currentLevel = SceneManager.GetActiveScene();
        player_1 = GameObject.Find("player_1");
        player_2 = GameObject.Find("player_2");
        player_3 = GameObject.Find("player_3");
    }
    
    void Update()
    {
        if (player_1.GetComponent<playerScript_ex01>().win && player_2.GetComponent<playerScript_ex01>().win && player_3.GetComponent<playerScript_ex01>().win)
        {
            print("WIN");
            if (currentLevel.buildIndex != 5)
                SceneManager.LoadScene(currentLevel.buildIndex + 1);
        }
    }
}
