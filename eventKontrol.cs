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
    public void olayDöndür()
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
        sonuctxt.text = "Çocuk seni bir güzel dövdü. \n -10 saðlýk";
        yasatlas.GetComponent<yasatla>().saglikekle(-10);
        sonucPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
    }
    public void görmezdenGel()
    {
        sonuctxt.text = "Yapacak bir þey olmamasý çok üzücü \n -10 mutluluk";
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
        sonuctxt.text = "korku içerisinde geri uyumaya çalýþtýn \n -10 mutluluk";
        gamemanagers.GetComponent<gameManager>().mutlulukEkle(-10);
        sonucPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
    }
    public void zorlaGeriAl()
    {
        sonuctxt.text = "Geri almaya çalýþýrken oyuncaðýn kýrýldý ve çocuk seni dövdü \n -20 mutluluk, -10 saglik";
        gamemanagers.GetComponent<gameManager>().mutlulukEkle(-20);
        yasatlas.GetComponent<yasatla>().saglikekle(-10);
        sonucPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
    }
    public void birSeyYapma()
    {
        sonuctxt.text = "Yapacak bir þey olmamasý çok üzücü \n -10 mutluluk";
        gamemanagers.GetComponent<gameManager>().mutlulukEkle(-10);
        sonucPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
    }

    public void agla2()
    {
        sonuctxt.text = "aðlaman kimsenin umrunda olmadý \n -10 mutluluk, -10 saðlýk";
        gamemanagers.GetComponent<gameManager>().mutlulukEkle(-10);
        yasatlas.GetComponent<yasatla>().saglikekle(-10);
        sonucPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
    }
    public void kosmayaDevamEt()
    {
        string isim = PlayerPrefs.GetString("isim");
        sonuctxt.text = "koþ " + isim + " koþ \n +20 mutluluk, -10 saðlýk";
        gamemanagers.GetComponent<gameManager>().mutlulukEkle(20);
        yasatlas.GetComponent<yasatla>().saglikekle(-10);
        sonucPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
    }

    public void NeymisDiyeBak()
    {
        sonuctxt.text = "Sadece rüzgardan sallanan aðaç dallarýymýþ. \n +10 mutluluk";
        gamemanagers.GetComponent<gameManager>().mutlulukEkle(+10);
        sonucPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
    }

    public void yorganýnAltýnaGir()
    {
        sonuctxt.text = "Korku içinde sabaha kadar uyuyamadýn \n -20 mutluluk";
        gamemanagers.GetComponent<gameManager>().mutlulukEkle(-20);
        sonucPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
    }
    public void pikkamanýmBen()
    {
        sonuctxt.text = "Sert bir düþüþ yaþayarak pikkaman olmadýðýný öðrendin \n -20 mutluluk, -20 saðlýk";
        gamemanagers.GetComponent<gameManager>().mutlulukEkle(-20);
        yasatlas.GetComponent<yasatla>().saglikekle(-20);
        sonucPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
    }
    public void salakDegilim()
    {
        sonuctxt.text = "Kaliteli bir çizgi film \n +10 mutluluk";
        gamemanagers.GetComponent<gameManager>().mutlulukEkle(10);
        sonucPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
    }
    public void ye()
    {
        sonuctxt.text = "Tadý çok güzeldi fakat zehirlendin \n +10 mutluluk -10 saðlýk";
        gamemanagers.GetComponent<gameManager>().mutlulukEkle(10);
        yasatlas.GetComponent<yasatla>().saglikekle(-10);
        sonucPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
    }
    public void yeme()
    {
        sonuctxt.text = "Yemediðin için üzüldün \n -20 mutluluk ";
        gamemanagers.GetComponent<gameManager>().mutlulukEkle(-20);
        sonucPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
    }






}
