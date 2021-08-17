using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region Singleton Class : GameManager
    public static GameManager Instance;

    void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }

        GenCharacter();
    }
    #endregion

    BallControl ball;
    public int move3Stars;
    public int move2Stars;
    public int move1Stars;
    public UIController uiCtrl;
    public GameObject[] PlayerMarbles;


    public int currentStarsNum= 0;
    public int starsNum;

    //public Trajectory trajectory;
    public Vector2 force;

    void Start()
    {
        ball = GameObject.FindGameObjectWithTag("Player").GetComponent<BallControl>();
    }

    void Update()
    {
        StarsPerLevel();
    }

    public void StarsPerLevel()
    {
        uiCtrl.text3Stars.text = " : Max Move " + move3Stars.ToString();
        uiCtrl.text2Stars.text = " : Max Moce " + move2Stars.ToString();
        uiCtrl.text1Stars.text = " : More Than " + move1Stars.ToString();
    }

    public void GenCharacter()
    {
        Instantiate(PlayerMarbles[PlayerPrefs.GetInt("SelectCharacter",0)], transform.position, Quaternion.identity);
    }
}
