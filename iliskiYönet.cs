using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class iliskiYönet : MonoBehaviour
{
    public GameObject annepanel,babapanel,ahmetPanel,aleynapanel,canPanel,fatmaPanel,korayPanel,ZeynepPanel,sonucPanel,olayPaneli;
    public Text sonuctxt,olayTxt;
    public GameObject gamemanagers;
    public List<string> karakterler = new List<string>();

    public void ölümsansi()
    {
        if (PlayerPrefs.GetInt("yas")<2)
        {
            karakterler.Add("babayas");
            karakterler.Add("anneyas");
            karakterler.Add("ahmetyas");
            karakterler.Add("aleynayas");
            karakterler.Add("canyas");
            karakterler.Add("fatmayas");
            karakterler.Add("korayyas");
            karakterler.Add("zeynepyas");
        }
        

        foreach (var item in karakterler)
        {
            if (PlayerPrefs.GetInt(item)>50)
            {
                string ölümsansi = item+"ölüm";
                if (PlayerPrefs.HasKey(ölümsansi))
                {
                    int deger = PlayerPrefs.GetInt(ölümsansi);
                    deger += 1;
                    PlayerPrefs.SetInt(ölümsansi, deger);
                    int ölümsans = 100 - PlayerPrefs.GetInt(ölümsansi);
                    int sans = Random.Range(1, ölümsans);
                    if (sans == 1)
                    {
                        karakteriÖldür(ölümsansi);
                    }
                }
                else
                {
                    PlayerPrefs.SetInt(ölümsansi, 1);
                }
                
            }
            Debug.Log(PlayerPrefs.GetInt("babayasölüm"));
        }
        
    }
    public void karakteriÖldür(string isim)
    {
        if (isim == "babayasölüm")
        {
            babapanel.SetActive(false);
            olayTxt.text = "babanı kaybettin F";
            olayPaneli.GetComponent<RectTransform>().DOScale(1, 1);
            karakterler.Remove("babayas");
        }
        else if (isim == "anneyasölüm")
        {
            annepanel.SetActive(false);
            olayTxt.text = "anneni kaybettin F";
            olayPaneli.GetComponent<RectTransform>().DOScale(1, 1);
            karakterler.Remove("anneyas");

        }
        else  if (isim == "ahmetyasölüm")
        {
            ahmetPanel.SetActive(false);
            olayTxt.text = "ahmet isimli arkadaşın kaybettin F";
            olayPaneli.GetComponent<RectTransform>().DOScale(1, 1);
            karakterler.Remove("ahmetyas");
        }
        else if (isim == "aleynayasölüm")
        {
            aleynapanel.SetActive(false);
            olayTxt.text = "aleyna isimli arkadaşını kaybettin F";
            olayPaneli.GetComponent<RectTransform>().DOScale(1, 1);
            karakterler.Remove("aleynayas");
        }
        else if (isim == "canyasölüm")
        {
            canPanel.SetActive(false);
            olayTxt.text = "can isimli arkadaşını kaybettin F";
            olayPaneli.GetComponent<RectTransform>().DOScale(1, 1);
            karakterler.Remove("canyas");
        }
        else if (isim == "fatmayasölüm")
        {
            fatmaPanel.SetActive(false);
            olayTxt.text = "fatma isimli arkadaşını kaybettin F";
            olayPaneli.GetComponent<RectTransform>().DOScale(1, 1);
            karakterler.Remove("fatmayas");
        }
        else if (isim == "korayyasölüm")
        {
            korayPanel.SetActive(false);
            olayTxt.text = "koray isimli arkadaşını kaybettin F";
            olayPaneli.GetComponent<RectTransform>().DOScale(1, 1);
            karakterler.Remove("korayyas");
        }
        else if (isim == "zeynepyasölüm")
        {
            ZeynepPanel.SetActive(false);
            olayTxt.text = "Zeynep isimli arkadaşını kaybettin F";
            olayPaneli.GetComponent<RectTransform>().DOScale(1, 1);
            karakterler.Remove("zeynepyas");


        }
        else
        {
            olayTxt.text = "Ölüm kısmında bir hata meydana geldi";
            olayPaneli.GetComponent<RectTransform>().DOScale(1, 1);
        }
    }
    public void geziSevenler(string isim)
    {
        if (PlayerPrefs.GetInt("enerji") > 10)
        {
            sonuctxt.text = isim + " ile geziye çıktınız çok mutlu gözüküyor, görünen o ki geziye çıkmayı çok seviyor \n +20 ilişki +5 mutluluk";
            iliskiEkle(isim, 20);
            gamemanagers.GetComponent<gameManager>().mutlulukEkle(5);
            gamemanagers.GetComponent<gameManager>().enerjiEkle(-10);
        }
        else
        {
            sonuctxt.text = "Yeterli enerji bulunmamaktadır.";
        }
        sonucPanel.GetComponent<RectTransform>().DOScale(1, 0.7f);

    }
    public void geziSevmeyenler(string isim)
    {
        if (PlayerPrefs.GetInt("enerji") > 10)
        {
            sonuctxt.text = isim + " ile geziye çıktınız sıkılmış gibi gözüküyor, görünen o ki geziye çıkmayı sevmiyor \n -20 ilişki -5 mutluluk";
            iliskiEkle(isim, -20);
            gamemanagers.GetComponent<gameManager>().mutlulukEkle(-5);
            gamemanagers.GetComponent<gameManager>().enerjiEkle(-10);
        }
        else
        {
            sonuctxt.text = "Yeterli enerji bulunmamaktadır.";
        }
        sonucPanel.GetComponent<RectTransform>().DOScale(1, 0.7f);



    }
    public void lokantaSevenler(string isim)
    {
        if (PlayerPrefs.GetInt("enerji") > 10)
        {
            sonuctxt.text = isim + " ile yemeğe çıktınız çok mutlu gözüküyor, görünen o ki lokantaya gitmeyi çok seviyor \n +20 ilişki +5 mutluluk";
            iliskiEkle(isim, 20);
            gamemanagers.GetComponent<gameManager>().mutlulukEkle(5);
            gamemanagers.GetComponent<gameManager>().enerjiEkle(-10);
        }
        else
        {
            sonuctxt.text = "Yeterli enerji bulunmamaktadır.";
        }
        sonucPanel.GetComponent<RectTransform>().DOScale(1, 0.7f);
    }
    public void lokantaSevmeyenler(string isim)
    {
        if (PlayerPrefs.GetInt("enerji") > 10)
        {
            sonuctxt.text = isim + " ile yemeğe çıktınız ama üzgün gözüküyor, görünen o ki lokantaya gitmeyi sevmiyor \n -20 ilişki -5 mutluluk";
            iliskiEkle(isim, -20);
            gamemanagers.GetComponent<gameManager>().mutlulukEkle(-5);
            gamemanagers.GetComponent<gameManager>().enerjiEkle(-10);
        }
        else
        {
            sonuctxt.text = "Yeterli enerji bulunmamaktadır.";

        }
        sonucPanel.GetComponent<RectTransform>().DOScale(1, 0.7f);

    }
    public void sohbetEt(string isim)
    {
        int sayi = Random.Range(1, 101);
        if (PlayerPrefs.GetInt("enerji")>0)
        {
            if (sayi < 66)
            {
                sonuctxt.text = isim + " ile olumlu bir sohbet gerçekleştirdin. \n +10 ilişki +5 mutluluk";
                iliskiEkle(isim, 10);
                gamemanagers.GetComponent<gameManager>().mutlulukEkle(5);
                gamemanagers.GetComponent<gameManager>().enerjiEkle(-1);
            }
            else
            {
                sonuctxt.text = isim + " ile olumsuz bir sohbet gerçekleştirdin. \n -10 ilişki -5 mutluluk";
                iliskiEkle(isim, -10);
                gamemanagers.GetComponent<gameManager>().mutlulukEkle(-5);
                gamemanagers.GetComponent<gameManager>().enerjiEkle(-1);
            }
        }
        else
        {
            sonuctxt.text ="Yeterli enerji yok";
        }
       
        sonucPanel.GetComponent<RectTransform>().DOScale(1, 0.7f);

    }
    public void paraiste(string isim)
    {
        int sayi2 = (111 - PlayerPrefs.GetInt(isim)) /10;
        int sayi = Random.Range(1, sayi2);
        string yasbelirle = isim + "yas";
        
        if (PlayerPrefs.GetInt("enerji") > 0)
        {
            if (sayi ==1)
            {
                int miktar;
                if (PlayerPrefs.GetInt(yasbelirle)<10)
                {
                    miktar = 100;
                }
                else if (PlayerPrefs.GetInt(yasbelirle) < 18)
                {
                    miktar = 500;
                }
                else if (PlayerPrefs.GetInt(yasbelirle) < 30)
                {
                    miktar = 10000;
                }
                else if (PlayerPrefs.GetInt(yasbelirle) < 50)
                {
                    miktar = 30000;
                }
                else
                {
                    miktar = 50000;
                }
                sonuctxt.text = isim + " sana " + miktar.ToString() + " TL vermeyi kabul etti \n -10 ilişki +10 mutluluk +" +miktar + "TL"  ;
                iliskiEkle(isim, -10);
                gamemanagers.GetComponent<gameManager>().mutlulukEkle(10);
                gamemanagers.GetComponent<gameManager>().paraEkle(miktar);
                gamemanagers.GetComponent<gameManager>().enerjiEkle(-1);
            }
            else
            {
                sonuctxt.text = isim + " sana para vermeyi kabul etmedi \n -5 mutluluk -10 ilişki";
                iliskiEkle(isim, -10);
                gamemanagers.GetComponent<gameManager>().mutlulukEkle(-5);
                gamemanagers.GetComponent<gameManager>().enerjiEkle(-1);
            }
        }
        else
        {
            sonuctxt.text = "Yeterli enerji yok";
        }
        sonucPanel.GetComponent<RectTransform>().DOScale(1, 0.7f);
    }
    public void iliskiEkle(string isim,int miktar)
    {
        
        int deger = PlayerPrefs.GetInt(isim);
        deger += miktar;
        PlayerPrefs.SetInt(isim, deger);
        if (PlayerPrefs.GetInt(isim) < 0)
        {
            PlayerPrefs.SetInt(isim, 0);
        }
        if (PlayerPrefs.GetInt(isim) > 100)
        {
            PlayerPrefs.SetInt(isim, 100);
        }
    }

    public void panelkappa()
    {
        sonucPanel.GetComponent<RectTransform>().DOScale(0, 1);
        olayPaneli.GetComponent<RectTransform>().DOScale(0, 1);
    }
    public void karakterGetirGötür()
    {
        if (PlayerPrefs.GetInt("yas")<7)
        {
            annepanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
            babapanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
            ahmetPanel.GetComponent<RectTransform>().DOScale(0, 0.5f);
            aleynapanel.GetComponent<RectTransform>().DOScale(0, 0.5f);
            canPanel.GetComponent<RectTransform>().DOScale(0, 0.5f);
            fatmaPanel.GetComponent<RectTransform>().DOScale(0, 0.5f);
            korayPanel.GetComponent<RectTransform>().DOScale(0, 0.5f);
            ZeynepPanel.GetComponent<RectTransform>().DOScale(0, 0.5f);
        }
        else if (PlayerPrefs.GetInt("yas") < 15)
        {
            annepanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
            babapanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
            ahmetPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
            aleynapanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
            canPanel.GetComponent<RectTransform>().DOScale(0, 0.5f);
            fatmaPanel.GetComponent<RectTransform>().DOScale(0, 0.5f);
            korayPanel.GetComponent<RectTransform>().DOScale(0, 0.5f);
            ZeynepPanel.GetComponent<RectTransform>().DOScale(0, 0.5f);
        }
        else if (PlayerPrefs.GetInt("yas") < 19)
        {
            annepanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
            babapanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
            ahmetPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
            aleynapanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
            canPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
            fatmaPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
            korayPanel.GetComponent<RectTransform>().DOScale(0, 0.5f);
            ZeynepPanel.GetComponent<RectTransform>().DOScale(0, 0.5f);
        }
        else
        {
            annepanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
            babapanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
            ahmetPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
            aleynapanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
            canPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
            fatmaPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
            korayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
            ZeynepPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
        }

    }
    public void yasatlat()
    {
        string[] yaslar = { "anneyas", "babayas", "ahmetyas", "aleynayas", "canyas", "fatmayas", "korayyas", "zeynepyas" };
        foreach (var item in yaslar)
        {
            int deger = PlayerPrefs.GetInt(item);
            deger += 1;
            PlayerPrefs.SetInt(item, deger);
        }
        
    }
}
