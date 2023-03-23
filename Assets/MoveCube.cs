using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Rigidbody2D rigidbody2D;
    public KeyCode upKey, downKey;
    public Color playerColor;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = playerColor;
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        

        if(Input.GetKey(upKey))
        {
            rigidbody2D.velocity = Vector2.up;
        }
        else if (Input.GetKey(downKey))
        {
            rigidbody2D.velocity = Vector2.down;
        }
        else
        {
            rigidbody2D.velocity = Vector2.zero;
        }




    }
}
