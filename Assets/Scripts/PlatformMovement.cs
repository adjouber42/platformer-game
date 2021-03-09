using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    public float x;
    public float y;
    public float timer;
    float time = 0;

    void Update()
    {
        if (time < timer)
        {
            transform.Translate(new Vector3(x, y, 0));
            time += Time.deltaTime;
        }
        else
        {
            x = -x;
            y = -y;
            time = 0;
        }
    }
}
