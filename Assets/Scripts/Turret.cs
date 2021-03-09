using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Turret : MonoBehaviour
{
    public int  i;
    private float   speed;
    private GameObject   bullet;
    private Scene currentLevel;

    void Start()
    {
        if (i == 0)
            speed = -0.01f;
        else
            speed = 0.01f;
        currentLevel = SceneManager.GetActiveScene();
        bullet = this.gameObject.transform.GetChild(0).gameObject;
    }

    void Update()
    {
        if (i == 0)
        {
            if (bullet.transform.position.x - transform.position.x > -5)
                bullet.transform.Translate(speed, 0, 0);
            else
                bullet.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        }
        else
        {
            if (bullet.transform.position.x - transform.position.x < 5)
                bullet.transform.Translate(speed, 0, 0);
            else
                bullet.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        }
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.layer == bullet.layer)
        {
            Destroy(transform.gameObject);
        }
    }
}
