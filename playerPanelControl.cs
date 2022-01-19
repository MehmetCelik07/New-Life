using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
public class playerPanelControl : MonoBehaviour
{
    public Text adSoyad,dogumtr;
    public GameObject maleImage, fameleImage;
    void Start()
    {
        //doðru cinsiyet iconunu aktif etme
        int cinsiyet = PlayerPrefs.GetInt("cinsiyet");
        if (cinsiyet == 1)
        {
            maleImage.SetActive(true);
        }
        else if (cinsiyet == 2)
        {
            fameleImage.SetActive(true);
        }
        adSoyad.text = PlayerPrefs.GetString("isim") + " " + PlayerPrefs.GetString("soyisim"); 
        dogumtr.text = PlayerPrefs.GetString("dogumtarihi") + " tarihinde doðdun";

    }

}
