using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleScript : MonoBehaviour
{
    public UIController uiCtrl;
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            uiCtrl.LoseLose();
            Debug.Log("LOSE");
        }
    }
}