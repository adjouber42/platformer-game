using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript_ex01 : MonoBehaviour
{
    private GameObject color;
    public float cam_size;
    private bool active;
    private bool jumping;
    private int nb_jump;
    public bool win;
    private int speed;
    private float jump;
    private bool power;
    private int speed_1;
    private int speed_2;
    private int speed_3;
    private float jump_1;
    private float jump_2;
    private float jump_3;
    private bool power_1;
    private bool power_2;
    private bool power_3;

    void Start()
    {
        cam_size = 1.5f;
        nb_jump = 0;
        speed = 2;
        jump = 250f;
        jumping = false;
        power = false;
        power_1 = false;
        power_2 = false;
        power_3 = false;
        if (gameObject.name == "player_1")
        {
            if (gameObject.tag == "red_object" || gameObject.tag == "brown_object"
                || gameObject.tag == "white_object" || gameObject.tag == "purple_object")
            {
                speed_1 = 2;
                jump_1 = 250f;
            }
            if (gameObject.tag == "blue_object")
            {
                speed_1 = 1;
                jump_1 = 150f;
            }
            if (gameObject.tag == "yellow_object")
            {
                speed_1 = 3;
                jump_1 = 350f;
            }
            if (gameObject.tag == "white_object" || gameObject.tag == "purple_object")
                power_1 = true;
        }
        else if (gameObject.name == "player_2")
        {
            if (gameObject.tag == "red_object" || gameObject.tag == "brown_object"
                || gameObject.tag == "white_object" || gameObject.tag == "purple_object")
            {
                speed_2 = 2;
                jump_2 = 250f;
            }
            if (gameObject.tag == "blue_object")
            {
                speed_2 = 1;
                jump_2 = 150f;
            }
            if (gameObject.tag == "yellow_object")
            {
                speed_2 = 3;
                jump_2 = 350f;
            }
            if (gameObject.tag == "white_object" || gameObject.tag == "purple_object")
                power_2 = true;
        }
        else if (gameObject.name == "player_3")
        {
            if (gameObject.tag == "red_object" || gameObject.tag == "brown_object"
                || gameObject.tag == "white_object" || gameObject.tag == "purple_object")
            {
                speed_3 = 2;
                jump_3 = 250f;
            }
            if (gameObject.tag == "blue_object")
            {
                speed_3 = 1;
                jump_3 = 150f;
            }
            if (gameObject.tag == "yellow_object")
            {
                speed_3 = 3;
                jump_3 = 350f;
            }
            if (gameObject.tag == "white_object" || gameObject.tag == "purple_object")
                power_3 = true;
        }

        if (gameObject.name == "player_1")
        {
                active = true;
                speed = speed_1;
                jump = jump_1;
                power = power_1;
        }
        else
            active = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            if (gameObject.name == "player_1")
            {
                active = true;
                speed = speed_1;
                jump = jump_1;
                power = power_1;
                cam_size = 1.5f;
            }
            else
                active = false;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            if (gameObject.name == "player_2")
            {
                active = true;
                speed = speed_2;
                jump = jump_2;
                power = power_2;
                cam_size = 1.5f;
            }
            else
                active = false;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            if (gameObject.name == "player_3")
            {
                active = true;
                speed = speed_3;
                jump = jump_3;
                power = power_3;
                cam_size = 1.5f;
            }
            else
                active = false;
        }
        if (!active)
        {
            GetComponent<Rigidbody2D>().mass = 1f;
            GetComponent<Rigidbody2D>().velocity = (new Vector2(0, GetComponent<Rigidbody2D>().velocity.y));
        }
        else
        {
            GetComponent<Rigidbody2D>().mass = 1f;
            if (Input.GetKey("left"))
                GetComponent<Rigidbody2D>().velocity = (new Vector2(-speed, GetComponent<Rigidbody2D>().velocity.y));
            else if (Input.GetKey("right"))
                GetComponent<Rigidbody2D>().velocity = (new Vector2(speed, GetComponent<Rigidbody2D>().velocity.y));
            else
                GetComponent<Rigidbody2D>().velocity = (new Vector2(0, GetComponent<Rigidbody2D>().velocity.y));            
            if (Input.GetKey("space") && !jumping)
            {
                nb_jump++;
                GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jump));
                jumping = true;
            }
            if (Input.GetKeyUp("space") && nb_jump == 1)
                nb_jump++;
            if (Input.GetKey("space") && nb_jump == 2 && gameObject.tag == "brown_object")
            {
                nb_jump++;
                if (GetComponent<Rigidbody2D>().velocity.y >= -1f)
                    GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jump));
                else
                    GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jump * 1.5f));
            }
            if ((power) && Input.GetKeyDown("f"))
            {
                if (gameObject.tag == "purple_object")
                {
                    if (cam_size == 1.5f)
                        cam_size = 5.0f;
                    else
                        cam_size = 1.5f;   
                }
                if (gameObject.tag == "white_object")
                {
                    if (gameObject.layer == 19)
                        gameObject.layer = 11;
                    else
                        gameObject.layer++;
                    if (gameObject.layer == 11)
                    {
                        color = GameObject.Find("red");
                        GetComponent<SpriteRenderer>().color = color.GetComponent<SpriteRenderer>().color;
                    }
                    if (gameObject.layer == 12)
                    {
                        color = GameObject.Find("blue");
                        GetComponent<SpriteRenderer>().color = color.GetComponent<SpriteRenderer>().color;
                    }
                    if (gameObject.layer == 13)
                    {
                        color = GameObject.Find("yellow");
                        GetComponent<SpriteRenderer>().color = color.GetComponent<SpriteRenderer>().color;
                    }
                    if (gameObject.layer == 14)
                    {
                        color = GameObject.Find("white");
                        GetComponent<SpriteRenderer>().color = color.GetComponent<SpriteRenderer>().color;
                    }
                    if (gameObject.layer == 15)
                    {
                        color = GameObject.Find("brown");
                        GetComponent<SpriteRenderer>().color = color.GetComponent<SpriteRenderer>().color;
                    }
                    if (gameObject.layer == 16)
                    {
                        color = GameObject.Find("purple");
                        GetComponent<SpriteRenderer>().color = color.GetComponent<SpriteRenderer>().color;
                    }
                }
            }
        }
    }

    void    OnCollisionEnter2D(Collision2D coll)
    {
        if(coll.contacts.Length > 0)
        {
            ContactPoint2D contact = coll.contacts[0];
            if(Vector3.Dot(contact.normal, Vector3.up) > 0.5)
            {
                nb_jump = 0;
                jumping = false;
            }
            if (coll.gameObject.tag == "move")
            {
                this.transform.parent = coll.transform;
            }
        }
    }

    void    OnCollisionExit2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "move")
        {
            this.transform.parent = null;
        }
    }

    void   OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == gameObject.name)
            win = true;
    }
}
