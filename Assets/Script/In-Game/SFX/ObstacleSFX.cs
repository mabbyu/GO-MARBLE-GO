using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSFX : MonoBehaviour
{
    public AudioSource obstacle;

    // Start is called before the first frame update
    void Start()
    {
        obstacle = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            obstacle.Play();
        }
        if (collision.gameObject.tag == "NPC")
        {
            obstacle.Play();
        }
    }
}