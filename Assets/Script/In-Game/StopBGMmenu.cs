using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopBGMmenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        BgSound.Instance.gameObject.GetComponent<AudioSource>().Pause();
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void PlayAudioMenu()
    {
        BgSound.Instance.gameObject.GetComponent<AudioSource>().Play();
    }
}
