using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
public class yasatla : MonoBehaviour
{
    public GameObject gameManergers,eventKontrol;
    public Text OkulTxt;
   

    public void yasAtlaBtn()
    {
        int toplamZeka = PlayerPrefs.GetInt("matematik") + PlayerPrefs.GetInt("fen") + PlayerPrefs.GetInt("dilBilimleri") + PlayerPrefs.GetInt("sosyalBilimler");
        int toplamSosyallik = PlayerPrefs.GetInt("karizma") + PlayerPrefs.GetInt("ticaret") + PlayerPrefs.GetInt("resim") + PlayerPrefs.GetInt("müzik");
        int toplamKondisyon = PlayerPrefs.GetInt("güc") + PlayerPrefs.GetInt("hiz") + PlayerPrefs.GetInt("dayaniklilik") + PlayerPrefs.GetInt("teknik");

        int denge = PlayerPrefs.GetInt("gelir") - PlayerPrefs.GetInt("gider");
        gameManergers.GetComponent<gameManager>().paraEkle(denge);
        gameManergers.GetComponent<gameManager>().mutlulukEkle(toplamSosyallik/4);
        gameManergers.GetComponent<gameManager>().enerjiEkle(toplamKondisyon/4);
        gameManergers.GetComponent<gameManager>().yasEkle(1);
        gameManergers.GetComponent<gameManager>().yetenekEkle(toplamZeka/4);
        KaliteyeGöreYasam();
        gameManergers.GetComponent<gameManager>().panalKappa();
        eventKontrol.GetComponent<eventKontrol>().olayDöndür();
        eventKontrol.GetComponent<iliskiYönet>().yasatlat();
        eventKontrol.GetComponent<iliskiYönet>().karakterGetirGötür();
        eventKontrol.GetComponent<iliskiYönet>().ölümsansi();
        gameManergers.GetComponent<uptage>().ailenBakmasin();
        yediOluncaOkulaGit();
        PlayerPrefs.SetInt("okulaGitti", 0);
        gameManergers.GetComponent<uptage>().güncelle();



    }
    public void saglikekle(int miktar)
    {
        if (PlayerPrefs.GetInt("saglik")<101 && PlayerPrefs.GetInt("saglik") > -1)
        {
            if (PlayerPrefs.HasKey("saglik"))
            {
                int deger = PlayerPrefs.GetInt("saglik");
                deger += miktar;
                PlayerPrefs.SetInt("saglik", deger);
            }
            gameManergers.GetComponent<uptage>().güncelle();
        }
       
    }
    public void giderEkle(int miktar)
    {
        int deger = PlayerPrefs.GetInt("gider");
        deger += miktar;
        PlayerPrefs.SetInt("gider", deger);
    }
    public void KaliteyeGöreYasam()
    {
        if (PlayerPrefs.GetInt("beslenme") ==1)
        {
            saglikekle(-10);

        }

        else if (PlayerPrefs.GetInt("beslenme") == 3)
        {
            saglikekle(10);
        }
        
        
        if (PlayerPrefs.GetInt("ev") == 1)
        {
            saglikekle(-5);
            gameManergers.GetComponent<gameManager>().mutlulukEkle(-5);

        }
        else if (PlayerPrefs.GetInt("ev") == 3)
        {
            saglikekle(5);
            gameManergers.GetComponent<gameManager>().mutlulukEkle(5);
        }

        if (PlayerPrefs.GetInt("giyinme") == 1)
        {
            gameManergers.GetComponent<gameManager>().mutlulukEkle(-10);
        }
        else if (PlayerPrefs.GetInt("giyinme") == 3)
        {
            gameManergers.GetComponent<gameManager>().mutlulukEkle(10);
        }


        if (PlayerPrefs.GetInt("ulasim") == 1)
        {
            saglikekle(-5);
            gameManergers.GetComponent<gameManager>().mutlulukEkle(-5);

        }
        else if (PlayerPrefs.GetInt("ulasim") == 3)
        {
            saglikekle(5);
            gameManergers.GetComponent<gameManager>().mutlulukEkle(5);
        }


    }
    public void yediOluncaOkulaGit()
    {
        if (PlayerPrefs.GetInt("yas") ==7)
        {
            eventKontrol.GetComponent<aktivite>().olaytxt.text = "Ýlk okula baþladýn. Mezun olmak için her sene okula gitmen gerekir";
            eventKontrol.GetComponent<aktivite>().olayPanel.GetComponent<RectTransform>().DOScale(1, 0.4f);
            PlayerPrefs.SetInt("okulDurumu", 1);
            gameManergers.GetComponent<uptage>().güncelle();
        }
       

    }
    public void Okulagit()
    {
        if (PlayerPrefs.GetInt("okulaGitti") ==0)
        {
            if (PlayerPrefs.GetInt("enerji") > 4)
            {

                if (PlayerPrefs.GetInt("okulDurumu")>0 && PlayerPrefs.GetInt("okulDurumu") < 5)
                {
                    gameManergers.GetComponent<gameManager>().enerjiEkle(-5);
                    PlayerPrefs.SetInt("okulaGitti", 1);
                    okulArttýr(1);
                    int sans = Random.Range(1, 5);
                    int sýnýf = PlayerPrefs.GetInt("okulDurumu");
                    if (sans ==1)
                    {
                        int deger = PlayerPrefs.GetInt("sosyalBilimler");
                        deger += 1;
                        PlayerPrefs.SetInt("sosyalBilimler", deger);
                        eventKontrol.GetComponent<aktivite>().olaytxt.text = "Tebrikler " + sýnýf + ". sýnýfa geçtin \n Sosyal bilimler yeteneðin 1 arttý";
                    }
                    else if (sans == 2)
                    {
                        int deger = PlayerPrefs.GetInt("dilBilimleri");
                        deger += 1;
                        PlayerPrefs.SetInt("dilBilimleri", deger);
                        eventKontrol.GetComponent<aktivite>().olaytxt.text = "Tebrikler " + sýnýf + ". sýnýfa geçtin \n Dil bilimleri yeteneðin 1 arttý";
                    }
                    else if (sans == 3)
                    {
                        int deger = PlayerPrefs.GetInt("fen");
                        deger += 1;
                        PlayerPrefs.SetInt("fen", deger);
                        eventKontrol.GetComponent<aktivite>().olaytxt.text = "Tebrikler " + sýnýf + ". sýnýfa geçtin \n Fen bilimleri yeteneðin 1 arttý";
                    }
                    else if (sans == 4)
                    {
                        int deger = PlayerPrefs.GetInt("matematik");
                        deger += 1;
                        PlayerPrefs.SetInt("matematik", deger);
                        eventKontrol.GetComponent<aktivite>().olaytxt.text = "Tebrikler " + sýnýf + ". sýnýfa geçtin \n Matematik yeteneðin 1 arttý";
                    }

                    
                    eventKontrol.GetComponent<aktivite>().olayPanel.GetComponent<RectTransform>().DOScale(1, 0.4f);
                }
                else if (PlayerPrefs.GetInt("okulDurumu") > 4 && PlayerPrefs.GetInt("okulDurumu") < 9)
                {
                    gameManergers.GetComponent<gameManager>().enerjiEkle(-5);
                    PlayerPrefs.SetInt("okulaGitti", 1);
                    okulArttýr(1);
                    int sans = Random.Range(1, 3);
                    int sýnýf = PlayerPrefs.GetInt("okulDurumu");
                    if (sans == 1)
                    {
                        int deger = PlayerPrefs.GetInt("sosyalBilimler");
                        deger += 1;
                        PlayerPrefs.SetInt("sosyalBilimler", deger);
                        int deger2 = PlayerPrefs.GetInt("dilBilimleri");
                        deger2 += 1;
                        PlayerPrefs.SetInt("dilBilimleri", deger);
                        eventKontrol.GetComponent<aktivite>().olaytxt.text = "Tebrikler " + sýnýf + ". " +
                            "sýnýfa geçtin \n Sosyal bilimler yeteneðin ve dil bilimleri yeneteneðin 1 arttý";
                    }
                    else if (sans == 2)
                    {
                        int deger = PlayerPrefs.GetInt("matematik");
                        deger += 1;
                        PlayerPrefs.SetInt("matematik", deger);
                        int deger2 = PlayerPrefs.GetInt("fen");
                        deger2 += 1;
                        PlayerPrefs.SetInt("fen", deger);
                        eventKontrol.GetComponent<aktivite>().olaytxt.text = "Tebrikler " + sýnýf + ". " +
                            "sýnýfa geçtin \n Matematik yeteneðin ve fen bilimleri yeneteneðin 1 arttý";
                    }
                    eventKontrol.GetComponent<aktivite>().olayPanel.GetComponent<RectTransform>().DOScale(1, 0.4f);

                }
                else if (PlayerPrefs.GetInt("okulDurumu") > 8 && PlayerPrefs.GetInt("okulDurumu") < 12)
                {
                    gameManergers.GetComponent<gameManager>().enerjiEkle(-5);
                    PlayerPrefs.SetInt("okulaGitti", 1);
                    okulArttýr(1);
                    int sýnýf = PlayerPrefs.GetInt("okulDurumu");
                    int deger = PlayerPrefs.GetInt("sosyalBilimler");
                    deger += 1;
                    PlayerPrefs.SetInt("sosyalBilimler", deger);
                    int deger2 = PlayerPrefs.GetInt("dilBilimleri");
                    deger2 += 1;
                    PlayerPrefs.SetInt("dilBilimleri", deger);
                    int deger3 = PlayerPrefs.GetInt("matematik");
                    deger3 += 1;
                    PlayerPrefs.SetInt("matematik", deger);
                    int deger4 = PlayerPrefs.GetInt("fen");
                    deger4 += 1;
                    PlayerPrefs.SetInt("fen", deger);
                    eventKontrol.GetComponent<aktivite>().olaytxt.text = "Tebrikler " + sýnýf + ". " +
                            "sýnýfa geçtin \n Matematik, fen, sosyal ve dil bilimleri yeteneklerin 1 arttý";
                    eventKontrol.GetComponent<aktivite>().olayPanel.GetComponent<RectTransform>().DOScale(1, 0.4f);
                }
                else if (PlayerPrefs.GetInt("okulDurumu") ==12)
                {
                    gameManergers.GetComponent<gameManager>().enerjiEkle(-5);
                    PlayerPrefs.SetInt("okulaGitti", 1);
                    okulArttýr(1);
                    int sýnýf = PlayerPrefs.GetInt("okulDurumu");
                    int deger = PlayerPrefs.GetInt("sosyalBilimler");
                    deger += 1;
                    PlayerPrefs.SetInt("sosyalBilimler", deger);
                    int deger2 = PlayerPrefs.GetInt("dilBilimleri");
                    deger2 += 1;
                    PlayerPrefs.SetInt("dilBilimleri", deger);
                    int deger3 = PlayerPrefs.GetInt("matematik");
                    deger3 += 1;
                    PlayerPrefs.SetInt("matematik", deger);
                    int deger4 = PlayerPrefs.GetInt("fen");
                    deger4 += 1;
                    PlayerPrefs.SetInt("fen", deger);
                    eventKontrol.GetComponent<aktivite>().olaytxt.text = "Tebrikler " +
                            "liseyi bitirdin artýk iþ hayatýna atýlabilir veya üniversiteye gidebilirsin. \n Matematik, fen, sosyal ve dil bilimleri yeteneklerin 1 arttý";
                    eventKontrol.GetComponent<aktivite>().olayPanel.GetComponent<RectTransform>().DOScale(1, 0.4f);
                }
                else
                {
                    eventKontrol.GetComponent<aktivite>().olaytxt.text = "Henüz okula baþlamadýn";
                    eventKontrol.GetComponent<aktivite>().olayPanel.GetComponent<RectTransform>().DOScale(1, 0.4f);
                }
                
            }
            else
            {
                eventKontrol.GetComponent<aktivite>().olaytxt.text = "Yeterli enerji yok";
                eventKontrol.GetComponent<aktivite>().olayPanel.GetComponent<RectTransform>().DOScale(1, 0.4f);
            }
            

        }
        else
        {
            eventKontrol.GetComponent<aktivite>().olaytxt.text = "Bu sene zaten okula gittin";
            eventKontrol.GetComponent<aktivite>().olayPanel.GetComponent<RectTransform>().DOScale(1, 0.4f);
        }
    }
    public void okulArttýr(int miktar)
    {
        int deger = PlayerPrefs.GetInt("okulDurumu");
        deger += miktar;
        PlayerPrefs.SetInt("okulDurumu", deger);
    }



}
