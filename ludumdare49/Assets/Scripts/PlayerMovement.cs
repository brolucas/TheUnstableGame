using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Sprites;

public class PlayerMovement : MonoBehaviour
{
    
    public float speed = 5f;
    private float h;
    private float v;

    public Sprite  side;
    public Sprite up;
    public Sprite down;
    public Sprite Happy;


    public Rigidbody2D playerbody;
    public SpriteRenderer sp;


    private void Start()
    {
        playerbody = GetComponent<Rigidbody2D>();
        sp = GetComponent<SpriteRenderer>();

    }
    private void Update()
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");
        if (v<0)
        {
            sp.sprite = down;
        }
        else if (v>0)
        {
            sp.sprite = up;
        }
        else if (h<0)
        {
            if(sp.flipX == false)
            {
                sp.sprite = side; ;
                sp.flipX = true;
            }
            else
            {
                sp.sprite = side;
            }
           
            
        }
        else if (h>0)
        {
            if (sp.flipX == true)
            {
                sp.flipX = false;
                sp.sprite = side;
            }
            else
            {
                sp.sprite = side;
            }
           
        }
    }
    private void FixedUpdate()  
    {
        playerbody.velocity = new Vector2(h, v) * speed;
    }






}
