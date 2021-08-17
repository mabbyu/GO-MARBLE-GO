using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LingakaranPlayer : MonoBehaviour
{
    public UIController uiCtrl;
    public bool stay;
    public float timeCheck;
    public GameManager gm;
    public int levelIndex;
    public int get3Stars;
    public int get2Stars;
    public int get1Stars;
    BallControl ball;

    void Start()
    {
        ball = GameObject.FindGameObjectWithTag("Player").GetComponent<BallControl>();
    }
    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if(timeCheck > 0)
            {
                timeCheck -= Time.deltaTime;
                Debug.Log("Time left : " + timeCheck);
            }
            else 
            {
                stay = true;
                if (stay == true)
                {
                    if(ball.moveCount <= get3Stars)
                    {
                        gm.starsNum = 3;
                        uiCtrl.Stars3();
                        Debug.Log(gm.starsNum);
                    }
                    if (ball.moveCount == get2Stars)
                    {
                        gm.starsNum = 2;
                        uiCtrl.Stars2();
                        Debug.Log(gm.starsNum);
                    }
                    if(ball.moveCount >= get1Stars)
                    {
                        gm.starsNum = 1;
                        uiCtrl.Stars1();
                        Debug.Log(gm.starsNum);
                    }
                    gm.currentStarsNum = gm.starsNum;

                    if (gm.currentStarsNum > PlayerPrefs.GetInt("Lv" + levelIndex))
                    {
                        PlayerPrefs.SetInt("Lv" + levelIndex, gm.starsNum);
                    }

                    Debug.Log("Current Stars: " + PlayerPrefs.GetInt("Lv" + levelIndex, gm.starsNum));
                }
            }
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.tag =="Player")
        {
            timeCheck = 5f;
            Debug.Log("Out Circle : " + timeCheck);
        }
    }
}