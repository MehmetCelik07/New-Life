using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class eventKontrol : MonoBehaviour
{
    public GameObject sonucPanel,yasatlas,gamemanagers;
    public GameObject[] eventPanels;
    public Text sonuctxt;
    public void olayD�nd�r()
    {
        int yas = PlayerPrefs.GetInt("yas");
        int sayi;
   

            sayi = Random.Range(0, 6);

      
        
        eventPanels[sayi].GetComponent<RectTransform>().DOScale(1, 0.5f);
        
    }
    public void panelKappa()
    {
        sonucPanel.GetComponent<RectTransform>().DOScale(0, 0.5f);
        foreach (var item in eventPanels)
        {
            item.GetComponent<RectTransform>().DOScale(0, 0.5f);
        }
    }
    public void sendeOnunlaALayEt()
    {
        sonuctxt.text = "�ocuk seni bir g�zel d�vd�. \n -10 sa�l�k";
        yasatlas.GetComponent<yasatla>().saglikekle(-10);
        sonucPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
    }
    public void g�rmezdenGel()
    {
        sonuctxt.text = "Yapacak bir �ey olmamas� �ok �z�c� \n -10 mutluluk";
        gamemanagers.GetComponent<gameManager>().mutlulukEkle(-10);
        sonucPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
    }
    public void agla()
    {
        sonuctxt.text = "Annen geldi ve seni teselli etti \n +10 mutluluk";
        gamemanagers.GetComponent<gameManager>().mutlulukEkle(10);
        sonucPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
    }
    public void geriUyu()
    {
        sonuctxt.text = "korku i�erisinde geri uyumaya �al��t�n \n -10 mutluluk";
        gamemanagers.GetComponent<gameManager>().mutlulukEkle(-10);
        sonucPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
    }
    public void zorlaGeriAl()
    {
        sonuctxt.text = "Geri almaya �al���rken oyunca��n k�r�ld� ve �ocuk seni d�vd� \n -20 mutluluk, -10 saglik";
        gamemanagers.GetComponent<gameManager>().mutlulukEkle(-20);
        yasatlas.GetComponent<yasatla>().saglikekle(-10);
        sonucPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
    }
    public void birSeyYapma()
    {
        sonuctxt.text = "Yapacak bir �ey olmamas� �ok �z�c� \n -10 mutluluk";
        gamemanagers.GetComponent<gameManager>().mutlulukEkle(-10);
        sonucPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
    }

    public void agla2()
    {
        sonuctxt.text = "a�laman kimsenin umrunda olmad� \n -10 mutluluk, -10 sa�l�k";
        gamemanagers.GetComponent<gameManager>().mutlulukEkle(-10);
        yasatlas.GetComponent<yasatla>().saglikekle(-10);
        sonucPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
    }
    public void kosmayaDevamEt()
    {
        string isim = PlayerPrefs.GetString("isim");
        sonuctxt.text = "ko� " + isim + " ko� \n +20 mutluluk, -10 sa�l�k";
        gamemanagers.GetComponent<gameManager>().mutlulukEkle(20);
        yasatlas.GetComponent<yasatla>().saglikekle(-10);
        sonucPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
    }

    public void NeymisDiyeBak()
    {
        sonuctxt.text = "Sadece r�zgardan sallanan a�a� dallar�ym��. \n +10 mutluluk";
        gamemanagers.GetComponent<gameManager>().mutlulukEkle(+10);
        sonucPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
    }

    public void yorgan�nAlt�naGir()
    {
        sonuctxt.text = "Korku i�inde sabaha kadar uyuyamad�n \n -20 mutluluk";
        gamemanagers.GetComponent<gameManager>().mutlulukEkle(-20);
        sonucPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
    }
    public void pikkaman�mBen()
    {
        sonuctxt.text = "Sert bir d���� ya�ayarak pikkaman olmad���n� ��rendin \n -20 mutluluk, -20 sa�l�k";
        gamemanagers.GetComponent<gameManager>().mutlulukEkle(-20);
        yasatlas.GetComponent<yasatla>().saglikekle(-20);
        sonucPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
    }
    public void salakDegilim()
    {
        sonuctxt.text = "Kaliteli bir �izgi film \n +10 mutluluk";
        gamemanagers.GetComponent<gameManager>().mutlulukEkle(10);
        sonucPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
    }
    public void ye()
    {
        sonuctxt.text = "Tad� �ok g�zeldi fakat zehirlendin \n +10 mutluluk -10 sa�l�k";
        gamemanagers.GetComponent<gameManager>().mutlulukEkle(10);
        yasatlas.GetComponent<yasatla>().saglikekle(-10);
        sonucPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
    }
    public void yeme()
    {
        sonuctxt.text = "Yemedi�in i�in �z�ld�n \n -20 mutluluk ";
        gamemanagers.GetComponent<gameManager>().mutlulukEkle(-20);
        sonucPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
    }






}
