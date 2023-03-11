using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisappearingPlatform : MonoBehaviour
{
    public float delayTime = 1f;

    private Collider2D collider2d;


    void Start()
    {
        collider2d = GetComponent<Collider2D>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            StartCoroutine(DisappearAfterDelay());
        }
    }

    IEnumerator DisappearAfterDelay()
    {
        yield return new WaitForSeconds(delayTime);
        gameObject.SetActive(false);


        yield return new WaitForSeconds(delayTime);
        gameObject.SetActive(true);


    }
}