using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCDetection : MonoBehaviour
{
    public UIController uiCTRL;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Pinggiran")
        {
            uiCTRL.LoseLose();
        }
    }
}
