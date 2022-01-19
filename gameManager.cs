using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;
public class gameManager : MonoBehaviour
{
    public GameObject studyPanel, speakingPanel, kondisyonPanel, ticaretPanel,aktivitePanel,karakterPaneli;
    public GameObject güncelle,levelUpAnim;
    public string hangi;
    
   
    public void Start()
    {
        güncelle.GetComponent<uptage>().güncelle();
        StartCoroutine(levelUpanim());
    }
    public void cikis()
    {
        SceneManager.LoadScene("MainScane");
    }
    public void panelAc(int hangiPanel)
    {
        //tek bir void ile tüm butonlarý kontrol ediyorum butondan gelen int deðiþkene göre hareket ediyor
        if (hangiPanel==1)
        {
            studyPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
            speakingPanel.GetComponent<RectTransform>().DOScale(0, 0.5f);
            kondisyonPanel.GetComponent<RectTransform>().DOScale(0, 0.5f);
            ticaretPanel.GetComponent<RectTransform>().DOScale(0, 0.5f);
            aktivitePanel.GetComponent<RectTransform>().DOScale(0, 0.5f);
            karakterPaneli.GetComponent<RectTransform>().DOScale(0, 0.5f);
        }
        else if (hangiPanel == 2)
        {
            studyPanel.GetComponent<RectTransform>().DOScale(0, 0.5f);
            speakingPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
            kondisyonPanel.GetComponent<RectTransform>().DOScale(0, 0.5f);
            ticaretPanel.GetComponent<RectTransform>().DOScale(0, 0.5f);
            aktivitePanel.GetComponent<RectTransform>().DOScale(0, 0.5f);
            karakterPaneli.GetComponent<RectTransform>().DOScale(0, 0.5f);
        }
        else if (hangiPanel == 3)
        {
            studyPanel.GetComponent<RectTransform>().DOScale(0, 0.5f);
            speakingPanel.GetComponent<RectTransform>().DOScale(0, 0.5f);
            kondisyonPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
            ticaretPanel.GetComponent<RectTransform>().DOScale(0, 0.5f);
            aktivitePanel.GetComponent<RectTransform>().DOScale(0, 0.5f);
            karakterPaneli.GetComponent<RectTransform>().DOScale(0, 0.5f);
        }
        else if (hangiPanel == 4)
        {
            studyPanel.GetComponent<RectTransform>().DOScale(0, 0.5f);
            speakingPanel.GetComponent<RectTransform>().DOScale(0, 0.5f);
            kondisyonPanel.GetComponent<RectTransform>().DOScale(0, 0.5f);
            ticaretPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
            aktivitePanel.GetComponent<RectTransform>().DOScale(0, 0.5f);
            karakterPaneli.GetComponent<RectTransform>().DOScale(0, 0.5f);
        }
        else if (hangiPanel == 5)
        {
            studyPanel.GetComponent<RectTransform>().DOScale(0, 0.5f);
            speakingPanel.GetComponent<RectTransform>().DOScale(0, 0.5f);
            kondisyonPanel.GetComponent<RectTransform>().DOScale(0, 0.5f);
            ticaretPanel.GetComponent<RectTransform>().DOScale(0, 0.5f);
            aktivitePanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
            karakterPaneli.GetComponent<RectTransform>().DOScale(0, 0.5f);
        }
        else if (hangiPanel == 6)
        {
            studyPanel.GetComponent<RectTransform>().DOScale(0, 0.5f);
            speakingPanel.GetComponent<RectTransform>().DOScale(0, 0.5f);
            kondisyonPanel.GetComponent<RectTransform>().DOScale(0, 0.5f);
            ticaretPanel.GetComponent<RectTransform>().DOScale(0, 0.5f);
            aktivitePanel.GetComponent<RectTransform>().DOScale(0, 0.5f);
            karakterPaneli.GetComponent<RectTransform>().DOScale(1, 0.5f);
        }

    }
    public void panalKappa()
    {
        // tek fonksiyon'u tüm panel kapama butonlarýna atýyorum.
        studyPanel.GetComponent<RectTransform>().DOScale(0, 0.5f);
        speakingPanel.GetComponent<RectTransform>().DOScale(0, 0.5f);
        kondisyonPanel.GetComponent<RectTransform>().DOScale(0, 0.5f);
        ticaretPanel.GetComponent<RectTransform>().DOScale(0, 0.5f);
        aktivitePanel.GetComponent<RectTransform>().DOScale(0, 0.5f);
        karakterPaneli.GetComponent<RectTransform>().DOScale(0, 0.5f);
    }
    

        
    public void paraEkle(int miktar)
    {
        
        if (PlayerPrefs.HasKey("para"))
        {
            int deger = PlayerPrefs.GetInt("para");
            deger += miktar;
            PlayerPrefs.SetInt("para", deger);
        }
        güncelle.GetComponent<uptage>().güncelle();


    }

    public void yasEkle(int miktar)
    {

        if (PlayerPrefs.HasKey("yas"))
        {
            int deger = PlayerPrefs.GetInt("yas");
            deger += miktar;
            PlayerPrefs.SetInt("yas", deger);
        }
        güncelle.GetComponent<uptage>().güncelle();


    }

    public void mutlulukEkle(int miktar)
    {

       
        if (PlayerPrefs.HasKey("mutluluk"))
        {
            if (PlayerPrefs.GetInt("mutluluk")<101 && PlayerPrefs.GetInt("mutluluk") > -1)
            {
                int deger = PlayerPrefs.GetInt("mutluluk");
                deger += miktar;
                PlayerPrefs.SetInt("mutluluk", deger);
            }
  
        }
        güncelle.GetComponent<uptage>().güncelle();


    }

    public void enerjiEkle(int miktar)
    {

        if (PlayerPrefs.HasKey("enerji"))
        {
            int deger = PlayerPrefs.GetInt("enerji");
            deger += miktar;
            PlayerPrefs.SetInt("enerji", deger);
        }
        güncelle.GetComponent<uptage>().güncelle();

    }

    public void yetenekEkle(int miktar)
    {

        if (PlayerPrefs.HasKey("yetenek"))
        {
            int deger = PlayerPrefs.GetInt("yetenek");
            deger += miktar;
            PlayerPrefs.SetInt("yetenek", deger);
        }
        güncelle.GetComponent<uptage>().güncelle();

    }
    IEnumerator levelUpanim()
    {
        while (true)
        {
            levelUpAnim.GetComponent<RectTransform>().DOScale(0.7f, 0.7f);
            yield return new WaitForSeconds(0.8f);
            levelUpAnim.GetComponent<RectTransform>().DOScale(1, 0.7f);
            yield return new WaitForSeconds(0.8f);
        }
    }


}
