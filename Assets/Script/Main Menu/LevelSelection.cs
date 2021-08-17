using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelSelection : MonoBehaviour
{
    [SerializeField] private bool unlocked;
    public Image lockImage;
    public GameObject[] stars;
    public Sprite goldStar;

    public Button[] button;

    private void Update()
    {
        UpdateLevelImage();
        UpdateLevelStatus();
    }

    private void UpdateLevelStatus()
    {
        int previousLevelIndex = int.Parse(gameObject.name) - 1;
        if(PlayerPrefs.GetInt("Lv" + previousLevelIndex) > 0)
        {
            unlocked = true;
        }
    }
    private void UpdateLevelImage()
    {
        if(unlocked == false) //if Unlocked is FALSE means this Level is LOCKED!!
        {
            lockImage.gameObject.SetActive(true);
            
            for(int i = 0; i < stars.Length; i++)
            {
                stars[i].gameObject.SetActive(false);
            }
        }
        else
        {
            lockImage.gameObject.SetActive(false);

            for (int i=0; i<stars.Length; i++)
            {
                stars[i].gameObject.SetActive(true);
            }

            for(int i=0; i<PlayerPrefs.GetInt("Lv"+gameObject.name); i++)
            {
                stars[i].gameObject.GetComponent<Image>().sprite = goldStar;
            }
        }
    }

    public void PressSelectionLevel(string levelName)
    {
        if(unlocked)
        {
            SceneManager.LoadScene(levelName);
        }
    }
}
