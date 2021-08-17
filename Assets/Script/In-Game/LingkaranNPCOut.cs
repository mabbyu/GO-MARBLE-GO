using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LingkaranNPCOut : MonoBehaviour
{
    public UIController uiCtrl;
    public bool empty;
    public float timeCheck;
    public int npcCount;
    public GameManager gm;
    BallControl ball;
    public int levelIndex;
    public int get3tars;
    public int get2tars;
    public int get1tars;

    void Start()
    {
        ball = GameObject.FindGameObjectWithTag("Player").GetComponent<BallControl>();
    }

    void Update()
    {
        WinNpcOut();
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "NPC")
        {
            npcCount+= 1;
            Debug.Log("npc +1");
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "NPC")
        {
            npcCount -= 1;
            Debug.Log("npc -1");
        }
    }
    public void WinNpcOut()
    {
       if(npcCount > 0)
        {
            empty = false;
        }
       else
        {
            empty = true;
            if (timeCheck > 0)
            {
                timeCheck -= Time.deltaTime;
            }
            else
            {
                if (ball.moveCount <= get3tars)
                {
                    gm.starsNum = 3;
                    uiCtrl.Stars3();
                }
                else if (ball.moveCount == get2tars)
                {
                    gm.starsNum = 2;
                    uiCtrl.Stars2();
                }
                else if (ball.moveCount >= get1tars)
                {
                    gm.starsNum = 1;
                    uiCtrl.Stars1();
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
