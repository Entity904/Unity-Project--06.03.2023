using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public float speed = 5f; // prêdkoœæ lotu w jednym kierunku

    public float flyRight, flyLeft;

    private bool movingRight = true;

    private void Update()
    {
        if (movingRight)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
            if (transform.position.x >= flyRight) // zmiana kierunku, gdy platforma przekroczy pewn¹ pozycjê
            {
                movingRight = false;
            }
        }
        else
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
            if (transform.position.x <= -flyLeft) // zmiana kierunku, gdy platforma przekroczy pewn¹ pozycjê
            {
                movingRight = true;
            }
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        collision.gameObject.transform.SetParent(gameObject.transform,true);
    }
     void OnCollisionExit2D(Collision2D collision)
    {   
        collision.gameObject.transform.parent = null;
    }
}
