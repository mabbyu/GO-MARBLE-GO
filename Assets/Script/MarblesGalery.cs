using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MarblesGalery : MonoBehaviour
{
    public Sprite[] MarblesImage; // List untuk gambar kelereng (Berurutan dengan penempatannya)
    GameObject[] GaleryItem; //Objek setiap kelereng yang di susun sesuai denngan list gambar sebelumnya
    private void Awake()
    {
        GaleryItem = new GameObject[MarblesImage.Length];

        for(int i=0; i< MarblesImage.Length; i++)
        {
            GaleryItem[i] =transform.GetChild(i).gameObject;

            GaleryItem[i].transform.GetChild(2).GetComponent<Image>().sprite = MarblesImage[i];
        }
    }

    public void SelectCharacter(int index)
    {
        PlayerPrefs.SetInt("SelectCharacter", index);
    }
}
