using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bounceSFX : MonoBehaviour
{
    public AudioSource bounce;

    // Start is called before the first frame update
    void Start()
    {
        bounce = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            bounce.Play();
        }
        if (collision.gameObject.tag == "NPC")
        {
            bounce.Play();
        }
    }
}