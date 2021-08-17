using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trajectory : MonoBehaviour
{
    #region Dots Trajectory Path
    /*
    [SerializeField] int dotsNumber;
    [SerializeField] GameObject dotsParent;
    [SerializeField] GameObject dotPrefab;
    [SerializeField] float dotSpacing;
    [SerializeField] [Range(0.01f, 0.3f)] float dotMinScale;
    [SerializeField] [Range(0.3f, 1f)] float dotMaxScale;

    Transform[] dotsList;

    //Dot Position
    Vector2 pos;
    float timeStamp;

    void Start()
    {
        Hide();
        PrepareDots();
    }
    void PrepareDots()
    {
        dotsList = new Transform[dotsNumber];
        dotPrefab.transform.localScale = Vector3.one * dotMaxScale;

        float scale = dotMaxScale;
        float scaleFactor = scale / dotsNumber;

        for (int i = 0; i < dotsNumber; i++)
        {
            dotsList[i] = Instantiate(dotPrefab, null).transform;
            dotsList[i].parent = dotsParent.transform;

            dotsList[i].localScale = Vector3.one * scale;
            if (scale > dotMinScale)
                scale -= scaleFactor;
        }
    }

    public void UpdateDots(Vector3 ballPos, Vector2 forceApplied)
    {
        timeStamp = dotSpacing;
        for (int i = 0; i < dotsNumber; i++)
        {
            pos.x = (ballPos.x + forceApplied.x * timeStamp);
            pos.y = (ballPos.y + forceApplied.y * timeStamp);
            dotsList[i].position = pos;
            timeStamp += dotSpacing;
        }
    }
    public void Show()
    {
        //Show the Dots
        dotsParent.SetActive(true);
    }

    public void Hide()
    {
        //Hide the Dots
        dotsParent.SetActive(false);
    }
    */
    #endregion

    #region Line Render Path
    LineRenderer linePath;
    public float maxLenght = 5f;

    void Start()
    {
        linePath = GetComponent<LineRenderer>();
    }

    public void UpdateLine()
    {

    }
    public void ShowLine()
    {
        linePath.enabled = true;
    }
    
    public void HideLine()
    {
        linePath.enabled = false;
    }
    #endregion
}
