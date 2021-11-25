using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
using DG.Tweening;

public class NewGameManager : MonoBehaviour
{
    public int cinsiyet;
    public GameObject clickErkek, ClickKadin,bslbtn,geriBtn,sonPanel,hataPanel,MaleImage,FemaleImage;
    string ad, soyad, anneadi, babaadi,cinsiyetstr;
    public Text adtxt, soyadtxt, anneaditxt, babaaditxt;
    public Text Sadtxt, Ssoyadtxt, Sanneaditxt, Sbabaaditxt,Scinsiyet;
    void Start()
    {
        cinsiyet = 0;
        StartCoroutine(btnGetir());
        
        
    }
    IEnumerator btnGetir()
    {
        //butonlarý geç getirmek için
        yield return new WaitForSeconds(3f);
        bslbtn.GetComponent<CanvasGroup>().DOFade(1, 0.5f).SetEase(Ease.InBack);
        yield return new WaitForSeconds(1f);
        geriBtn.GetComponent<CanvasGroup>().DOFade(1, 0.5f).SetEase(Ease.InBack);
    }
    public void cinsiyetSecmeErkek()
    {
        //cisniyet erkekse 1 kadýnsa 2 olarak iþaretliyor
        cinsiyet = 1;
        clickErkek.GetComponent<CanvasGroup>().DOFade(1, 0.3f);
        ClickKadin.GetComponent<CanvasGroup>().DOFade(0, 0.3f);
    }
    public void cinsiyetSecmeKadin()
    {
        cinsiyet = 2;
        clickErkek.GetComponent<CanvasGroup>().DOFade(0, 0.3f);
        ClickKadin.GetComponent<CanvasGroup>().DOFade(1, 0.3f);
    }
    public void baslaBtn()
    {
        //ad soyad anne adý babaadý 2 den küçükse veya cisniyet sýfýr ise hata ekranýný açýyor
        if (adtxt.text.Length>2 && soyadtxt.text.Length>2 && anneaditxt.text.Length>2 && babaaditxt.text.Length>2 && cinsiyet!=0)
        {

            //cinsiyet 1 ise erkek iconu 2 ise kadýnlýk iconunu açýyor
            if (cinsiyet ==1)
            {
                MaleImage.SetActive(true);
            }
            else if (cinsiyet == 2)
            {
                FemaleImage.SetActive(true);
            }

            //daha sonra kaydetmek üzere input field'daki textleri deðiþkenlere atýyor.
            ad = adtxt.text;
            soyad = soyadtxt.text;
            anneadi = anneaditxt.text;
            babaadi = babaaditxt.text;

            //son kýsýmda yazdýrmak için 
            Sadtxt.text =ad +" "+ soyad;
            Sanneaditxt.text = anneadi;
            Sbabaaditxt.text = babaadi;
            sonPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);

          


        }
        else
        {
            hataPanel.GetComponent<RectTransform>().DOScale(1, 0.3f);
        }
      


    }
    public void hataPanelkapa()
    {
        hataPanel.GetComponent<RectTransform>().DOScale(0, 0.3f);
    }
    public void sonPanelbaslaBtn()
    {
        //datetime ile þuanki tarihi alýp bunu bir string deðiþkene gün/ay/yýl þeklinde yazdýrýyorum ardýndan bir playerprefs ile kaydediyorum.
        DateTime dogumtarihi = DateTime.Now;
        string dogumtr = dogumtarihi.Day.ToString() + " / " + dogumtarihi.Month.ToString() + " / " + dogumtarihi.Year.ToString();
        //oyuncu bilgilerini kayýt altýna alýyor ve gamelevel sahnesini yüklüyor
        PlayerPrefs.SetString("dogumtarihi",dogumtr);
        PlayerPrefs.SetInt("save", 1);
        PlayerPrefs.SetString("isim", ad);
        PlayerPrefs.SetString("soyisim", soyad);
        PlayerPrefs.SetString("anneadi", anneadi);
        PlayerPrefs.SetString("babaadi", babaadi);
        PlayerPrefs.SetInt("cinsiyet", cinsiyet);
        SceneManager.LoadScene("GameLevel");
    }
    public void sonPanelGeriBtn()
    {
        sonPanel.GetComponent<RectTransform>().DOScale(0, 0.5f);
    }
    public void geridön()
    {
        SceneManager.LoadScene("MainScane");
    }
  
   
    
}
