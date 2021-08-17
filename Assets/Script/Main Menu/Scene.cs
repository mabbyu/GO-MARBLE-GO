using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{
    // public GameObject pauseGame;
    public string nameScene;
    public float stayTime;
    float currentTime;
    public string numberScene;
    LingakaranPlayer lingkaran;
    void Start()
    {
        currentTime = stayTime;
    }


    // Update is called once per frame
    void Update()
    {
        numberScene = SceneManager.GetActiveScene().name;
        MoveFromMainMenu();
        currentTime -= Time.deltaTime;
        if (numberScene == "Splash STMM")
        {
            if (currentTime <= 0)
            {
                SceneManager.LoadScene(1);
            }
        }
    }
    IEnumerator SplashToMenu()
    {
        yield return new WaitForSeconds(stayTime);
        //numberScene = 1;
        Debug.Log("Loaded Scene 1");
    }
    public void PauseGame()
    {
        //pauseGame.SetActive(true);
    }

    //pindah scene menu
    public void MenuScene()
    {
        SceneManager.LoadScene("Main Menu");
    }

    //pindah scene galeri
    public void GaleriScene()
    {
        SceneManager.LoadScene("Galeri");
    }

    //pindah scene setting
    public void SettingScene()
    {
        SceneManager.LoadScene("Setting");
    }

    //pindah scene pilih level
    public void PilihLevelScene()
    {
        SceneManager.LoadScene("Pilih Level");
    }

    //keluar dari game
    public void KeluarScene()
    {
        Application.Quit();
    }

    //pindah ke scene credit
    public void PindahCreditScene()
    {
        SceneManager.LoadScene("Credit");
    }

    public void MoveFromMainMenu()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began || Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Tap The Screen");
            SceneManager.LoadScene("Galeri");
        }
    }

    public void UjiCoba()
    {
        SceneManager.LoadScene("Uji Coba 2");
    }

    public void UjiCoba2()
    {
        SceneManager.LoadScene("Uji Coba 3");
    }

    public void GoToScene()
    {
        SceneManager.LoadScene(nameScene);
    }
}
