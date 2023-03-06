using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test1Script : MonoBehaviour
{
    public Rigidbody2D rb;

    public float upForce = 300;

    public float speed = 1000;

    public float runSpeed = 3000;

    public bool isGrounded = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift)) //sprint
        {
            rb.velocity = new Vector2(Input.GetAxis("Horizontal") * runSpeed * Time.deltaTime, rb.velocity.y);
        }
        else
        {
            rb.velocity = new Vector2(Input.GetAxis("Horizontal") * speed * Time.deltaTime, rb.velocity.y); //deltatime sluzy do usredniania predkosci niezaleznie od ilosci klatek                                                                                                   //przypisywanie wartosci ruchu w poziomie
        }
        if (Input.GetKeyDown(KeyCode.UpArrow) && isGrounded)
        {
            rb.AddForce(Vector2.up * upForce);
            isGrounded = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isGrounded = true;
    }
}
