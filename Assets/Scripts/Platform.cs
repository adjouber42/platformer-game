using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Physics2D.IgnoreLayerCollision(11, 9);
		Physics2D.IgnoreLayerCollision(11, 10);
		Physics2D.IgnoreLayerCollision(12, 8);
		Physics2D.IgnoreLayerCollision(12, 10);
		Physics2D.IgnoreLayerCollision(13, 8);
		Physics2D.IgnoreLayerCollision(13, 9);
    }
}
