using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutArea : MonoBehaviour
{
    public UIController uiCtrl;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && collision.gameObject.tag == "NPC")
        {
            Debug.Log("DALAM AREA");
        }
    }
}
