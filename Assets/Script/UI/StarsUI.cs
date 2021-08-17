using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarsUI : MonoBehaviour
{
    public Text starsText;

    private void Update()
    {
        UpdateStarsUI();
    }
    private void UpdateStarsUI()
    {
        int sum = 0;

        for(int i=1; i<16; i++)
        {
            sum += PlayerPrefs.GetInt("Lv" + i.ToString());
        }
        starsText.text = sum + "/" + 24;
    }
}
