using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    #region Public Area
    public GameObject Win3Stars;
    public GameObject Win2Stars;
    public GameObject Win1Stars;
    public GameObject losePanelGame;
    public GameObject pausePanel;
    public GameObject infoBintang;
    public GameObject hintPanel;
    public GameObject nextHintPanel;
    public GameObject[] stars;
    public bool playerWin;
    public bool openInfo;
    public bool pause;
    public bool hint1;
    public bool hint2;
    public Text uiStars;
    public Text text3Stars;
    public Text text2Stars;
    public Text text1Stars;

    GameManager gm;

    #endregion

    #region Private Area
    #endregion
    // Start is called before the first frame update
    void Start()
    {
        Win1Stars.SetActive(false);
        Win2Stars.SetActive(false);
        Win3Stars.SetActive(false);
        losePanelGame.SetActive(false);
        playerWin = false;
        Data.isWin = false;
        Data.isLose = false;
    }
    public void Stars3()
    {
        Win3Stars.SetActive(true);
        playerWin = true;
        Data.isWin = true;
        Data.isLose = false;
    }
    public void Stars2()
    {
        Win2Stars.SetActive(true);
        playerWin = true;
        Data.isWin = true;
        Data.isLose = false;
    }
    public void Stars1()
    {
        Win1Stars.SetActive(true);
        playerWin = true;
        Data.isWin = true;
        Data.isLose = false;
    }
    public void PauseGame()
    {
        pause = true;
        pausePanel.SetActive(true);
    }
    public void HintGame1()
    {
        hint1 = true;
        pause = true;
        hintPanel.SetActive(true);
        nextHintPanel.SetActive(false);
        pausePanel.SetActive(false);        
    }
    public void HintGame2()
    {
        hint2 = true;
        pause = true;
        nextHintPanel.SetActive(true);
        hintPanel.SetActive(false);
        pausePanel.SetActive(false);
    }
    public void ResumeGame()
    {
        pause = false;
        hint1 = false;
        hint2 = false;
        pausePanel.SetActive(false);
        nextHintPanel.SetActive(false);
        hintPanel.SetActive(false);
    }
    
    public void LoseLose()
    {
        losePanelGame.SetActive(true);
        Debug.Log("YOU LOSE");
        Data.isLose = true;
        Data.isWin = false;
    }

    public void InfoBintang()
    {
        if(openInfo == false)
        {
            infoBintang.SetActive(true);
            openInfo = true;
        }
        else
        {
            infoBintang.SetActive(false);
            openInfo = false;
        }
    }

}
