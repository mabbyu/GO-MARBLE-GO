using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LingkaranMerah : MonoBehaviour
{
    public UIController uiCtrl;
    public float timeCheck;
    public int countNpc;
    public int levelIndex;
    public int get3Stars;
    public int get2Stars;
    public int get1Stars;
    public GameManager gm;
    BallControl ball;

    void Start()
    {
        ball = GameObject.FindGameObjectWithTag("Player").GetComponent<BallControl>();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "NPC");
        countNpc += 1;
        Debug.Log("Kelereng Masuk");
        Debug.Log("Jumlah Kelereng : " + countNpc);
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "NPC");
        countNpc -= 1;
        Debug.Log("Kelereng Keluar");
        Debug.Log("Jumlah Kelereng : " + countNpc);
    }

    public void NpcIn()
    {
        if (timeCheck > 0)
        {
            timeCheck -= Time.deltaTime;
        }
        else
        {
            if (ball.moveCount <= get3Stars)
            {
                gm.starsNum = 3;
                uiCtrl.Stars3();
            }
            else if (ball.moveCount == get2Stars)
            {
                gm.starsNum = 2;
                uiCtrl.Stars2();
            }
            else if (ball.moveCount >= get1Stars)
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
