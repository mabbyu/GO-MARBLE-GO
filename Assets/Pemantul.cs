using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pemantul : MonoBehaviour
{
    public GameManager gm;
    BallControl ball;
    void Start()
    {
        ball = GameObject.FindGameObjectWithTag("Player").GetComponent<BallControl>();
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            ball.rb.velocity = gm.force * ball.addForce;
            Debug.Log("F" + gm.force);
        }
    }
}
