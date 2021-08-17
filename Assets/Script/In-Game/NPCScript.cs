using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCScript : MonoBehaviour
{
    [HideInInspector] public Rigidbody2D rb;
    [HideInInspector] public CircleCollider2D col;

    public AudioClip kelereng;
    public AudioSource bergerak;

    public Animator animator;

    public float pushForce = 4f;

    // Start is called before the first frame update
    void Start()
    {
        bergerak = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        rb = GetComponent<Rigidbody2D>();
        if (rb.velocity.magnitude <= 0.5f)
        {
            animator.SetBool("move", false);
            bergerak.Stop();
        }
        else
        {
            animator.SetBool("move", true);
            if (bergerak.isPlaying == false)
                bergerak.Play();
        }
        if (Data.isWin)
        {
            rb.velocity = new Vector2(0, 0);
        }
        if (Data.isLose)
        {
            rb.velocity = new Vector2(0, 0);
        }
    }

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Mantul")
        {
            rb.velocity = new Vector2(pushForce * 1.5f, rb.velocity.y);
        }
        if (collision.gameObject.tag == "Player")
        {
            GetComponent<AudioSource>().PlayOneShot(kelereng);
        }
        if (collision.gameObject.tag == "Hole")
        {
            Destroy(gameObject);
        }
    }
}