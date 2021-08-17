using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDestroy : MonoBehaviour
{
    public UIController uiCtrl;

    private void OnTriggerEnter2D(Collider2D collision)
    {
      if(collision.gameObject.tag == "Hole")
        {
            Destroy(gameObject);
            uiCtrl.LoseLose();
            Debug.Log("HOLE");
        }
    }
}
