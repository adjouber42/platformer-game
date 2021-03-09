using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
    GameObject      current;
    private GameObject   player_1;
    private GameObject   player_2;
    private GameObject   player_3;
    
    void Start()
    {
        player_1 = GameObject.Find("player_1");
        player_2 = GameObject.Find("player_2");
        player_3 = GameObject.Find("player_3");
        current = player_1;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
            current = player_1;
        if (Input.GetKeyDown(KeyCode.Alpha2))
            current = player_2;
        if (Input.GetKeyDown(KeyCode.Alpha3))
            current = player_3;
        Transform t;
		t = current.GetComponent<Transform> (); 
		transform.localPosition = new Vector3 (t.position.x, t.position.y, -8.0f);
        GetComponent<Camera>().orthographicSize = current.GetComponent<playerScript_ex01>().cam_size;
    }
}
