using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPlatform : MonoBehaviour
{
    private GameObject plat;
    public int i;

    void Start()
    {
        plat = this.gameObject.transform.GetChild(0).gameObject;
    }

    void Update()
    {
        if (i == 0)
        {
            plat.layer = 8;
            plat.GetComponent<Renderer>().material.color = Color.red;
        }
        if (i == 1)
        {
            plat.layer = 9;
            plat.GetComponent<Renderer>().material.color = Color.blue;
        }
        if (i == 2)
        {
            plat.layer = 10;
            plat.GetComponent<Renderer>().material.color = Color.yellow;
        }
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        transform.position = new Vector3(transform.position.x, transform.position.y - 0.03f, transform.position.z);
        plat.transform.position = new Vector3(plat.transform.position.x, plat.transform.position.y + 0.03f, plat.transform.position.z);
        if (i < 2)
            i++;
        else
            i = 0;
    }

    void OnTriggerExit2D(Collider2D coll)
    {
        plat.transform.position = new Vector3(plat.transform.position.x, plat.transform.position.y - 0.03f, plat.transform.position.z);
        transform.position = new Vector3(transform.position.x, transform.position.y + 0.03f, transform.position.z);
    }
}
