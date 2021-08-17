using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    [HideInInspector] public Rigidbody2D rb;
    [HideInInspector] public CircleCollider2D col;

    public UIController uiCtrl;
    public GameManager gm;
    public float addForce;
    public Animator animator;
    public int moveCount;

    public AudioSource bergerak;

    [HideInInspector] public Vector3 pos
    {
        get { return transform.position; }
    }
    Camera cam;
    public float pushForce = 4f;
    bool isDragging = false;
    public bool marbleMove;
    Touch touch;
    Vector2 startPoint;
    Vector2 endPoint;
    Vector2 direction;
    float distance;

    //public GameObject Trajectory;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        col = GetComponent<CircleCollider2D>();
        animator = GetComponent<Animator>();
    }
    void Start()
    {
        cam = Camera.main;
        moveCount = 0;
        bergerak = GetComponent<AudioSource>();
    }
    void Update()
    {
        rb = GetComponent<Rigidbody2D>();
        if (Data.isWin == false)

        {
            #region Touch Controller
            // Touch controller
            if (Input.touchCount > 0)
            {
                touch = Input.GetTouch(0);

                if (touch.phase == TouchPhase.Began)
                {
                    isDragging = true;
                    OnDragStart();
                }

                if (touch.phase == TouchPhase.Moved)
                {
                    OnDrag();
                    bergerak.Stop();
                }

                if (touch.phase == TouchPhase.Ended)
                {
                    isDragging = false;
                    OnDragEnd();
                }
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
            #endregion

            #region Mouse Controller
            // Mouse controller
            if (Input.GetMouseButtonDown(0))
            {
                isDragging = true;
                OnDragStart();
            }

            if (isDragging)
            {
                OnDrag();
                bergerak.Stop();
            }

            if (Input.GetMouseButtonUp(0))
            {
                isDragging = false;
                OnDragEnd();

            }
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
            #endregion

            //rotation
            //Vector3 mousePos = Input.mousePosition;
            //mousePos.x = 5.23f;

            //Vector3 objectPos = Camera.main.WorldToScreenPoint(Trajectory.transform.position);
            //mousePos.z = mousePos.z - objectPos.z;
            //mousePos.y = mousePos.y - objectPos.y;

            //float angle = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg;
            //Trajectory.transform.rotation = Quaternion.Euler(new Vector3(angle, angle, 0));
        }
    }

    void OnDragStart()
    {
        startPoint = cam.ScreenToWorldPoint(Input.mousePosition);
        //Trajectory.SetActive(true);
    }
    void OnDrag()
    {
        endPoint = cam.ScreenToWorldPoint(Input.mousePosition);
        distance = Vector2.Distance(startPoint, endPoint);
        direction = (startPoint - endPoint).normalized;
        //rb.velocity = direction * distance * pushForce;
        //Debug Only
        //Debug.DrawLine(startPoint, endPoint);
        //trajectory.UpdateDots(ball.pos, force);

    }
    public void OnDragEnd()
    {
        moveCount++;
        rb.velocity = direction * distance * pushForce;
        //Trajectory.SetActive(false);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Mantul")
        {
            rb.velocity = new Vector2(pushForce * 1.5f, rb.velocity.y);
        }
    }
}