using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleSFX : MonoBehaviour
{
    public AudioSource hole;

    // Start is called before the first frame update
    void Start()
    {
        hole = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            hole.Play();
        }
        if (collision.gameObject.tag == "NPC")
        {
            hole.Play();
        }
    }
}