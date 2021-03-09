using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    private GameObject   exit;
    
    void Start()
    {
        exit = this.gameObject.transform.GetChild(0).gameObject;
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        coll.transform.position = exit.transform.position;
    }
}
