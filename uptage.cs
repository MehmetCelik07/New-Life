using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;


public class uptage : MonoBehaviour
{
    public Text yas, mutluluk, saglik, enerji, para, matematik, fen, dilBilimleri, sosyalBilimler, karizma, ticaret, resim, müzik, güc, hiz, dayaniklilik, teknik,ticaret2;
    public Text toplamZeka, toplamSosyallik, toplamKondisyon;
    public Text yas2, enerji2, saglik2, mutluluk2, para2,gelir,gider,denge,KalanYetenek,akEnerji,akPara,OkulTxt1,OkulTxt2,mezunOkulTxt;
    public int zeka, sosyallik, kondisyon;
    public GameObject beslenme1, beslenme2, beslenme3, ulasim1, ulasim2, ulasim3, ev1, ev2, ev3, giyinme1, giyinme2, giyinme3,beslenme0,ulasim0,ev0,giyinme0,olayPanel, gameobce;
    public GameObject[] yükseltmeler;
    public Text annei, anneyas, babai, babayas, ahmeti, ahmetyas, aleynai, aleynayas, cani, canyas, fatmai, fatmayas, korayi, korayyas, zeynepi, zeynepyas,olayTxt;


    public void güncelle()
    {
        yas.text = PlayerPrefs.GetInt("yas").ToString();
        mutluluk.text = PlayerPrefs.GetInt("mutluluk").ToString();
        saglik.text = PlayerPrefs.GetInt("saglik").ToString();
        enerji.text = PlayerPrefs.GetInt("enerji").ToString();
        akEnerji.text = PlayerPrefs.GetInt("enerji").ToString();
        para.text = PlayerPrefs.GetInt("para").ToString();
        akPara.text = PlayerPrefs.GetInt("para").ToString();
        matematik.text = PlayerPrefs.GetInt("matematik").ToString();
        fen.text = PlayerPrefs.GetInt("fen").ToString();
        dilBilimleri.text = PlayerPrefs.GetInt("dilBilimleri").ToString();
        sosyalBilimler.text = PlayerPrefs.GetInt("sosyalBilimler").ToString();
        karizma.text = PlayerPrefs.GetInt("karizma").ToString();
        ticaret.text = PlayerPrefs.GetInt("ticaret").ToString();
        ticaret2.text = PlayerPrefs.GetInt("ticaret").ToString();
        resim.text = PlayerPrefs.GetInt("resim").ToString();
        müzik.text = PlayerPrefs.GetInt("müzik").ToString();
        güc.text = PlayerPrefs.GetInt("güc").ToString();
        hiz.text = PlayerPrefs.GetInt("hiz").ToString();
        dayaniklilik.text = PlayerPrefs.GetInt("dayaniklilik").ToString();
        teknik.text = PlayerPrefs.GetInt("teknik").ToString();
        para2.text = PlayerPrefs.GetInt("para").ToString();
        enerji2.text = PlayerPrefs.GetInt("enerji").ToString();
        mutluluk2.text = PlayerPrefs.GetInt("mutluluk").ToString();
        yas2.text = PlayerPrefs.GetInt("yas").ToString();
        saglik2.text = PlayerPrefs.GetInt("saglik").ToString();

        gelir.text = PlayerPrefs.GetInt("gelir").ToString();
        gider.text = PlayerPrefs.GetInt("gider").ToString();
        int dengee = PlayerPrefs.GetInt("gelir") - PlayerPrefs.GetInt("gider");
        denge.text = dengee.ToString();
        KalanYetenek.text = PlayerPrefs.GetInt("yetenek").ToString();
        if (PlayerPrefs.GetInt("yetenek")>0)
        {
            foreach (var item in yükseltmeler)
            {
                item.SetActive(true);
            }
        }

        else
        {
            foreach (var item in yükseltmeler)
            {
                item.SetActive(false);
            }
        }



        zeka = PlayerPrefs.GetInt("matematik") + PlayerPrefs.GetInt("fen") + PlayerPrefs.GetInt("dilBilimleri") + PlayerPrefs.GetInt("sosyalBilimler");
        sosyallik = PlayerPrefs.GetInt("karizma") + PlayerPrefs.GetInt("ticaret") + PlayerPrefs.GetInt("resim") + PlayerPrefs.GetInt("müzik");
        kondisyon = PlayerPrefs.GetInt("güc") + PlayerPrefs.GetInt("hiz") + PlayerPrefs.GetInt("dayaniklilik") + PlayerPrefs.GetInt("teknik");
        toplamZeka.text = zeka.ToString();
        toplamSosyallik.text = sosyallik.ToString();
        toplamKondisyon.text = kondisyon.ToString();
        kaliteYönetim();
        yüzOluncaKapa();
        saglikvemutluluk();
        yasveiliskiGüncelle();
        yüzeEsitle();
        okuldurumunuGüncelle();
        
       

    }

    
    public void yasveiliskiGüncelle()
    {
        annei.text = PlayerPrefs.GetInt("anne").ToString();
        babai.text = PlayerPrefs.GetInt("baba").ToString();
        ahmeti.text = PlayerPrefs.GetInt("ahmet").ToString();
        aleynai.text = PlayerPrefs.GetInt("aleyna").ToString();
        cani.text = PlayerPrefs.GetInt("can").ToString();
        fatmai.text = PlayerPrefs.GetInt("fatma").ToString();
        korayi.text = PlayerPrefs.GetInt("koray").ToString();
        zeynepi.text = PlayerPrefs.GetInt("zeynep").ToString();

        babayas.text = PlayerPrefs.GetInt("anneyas").ToString();
        anneyas.text = PlayerPrefs.GetInt("babayas").ToString();
        ahmetyas.text = PlayerPrefs.GetInt("ahmetyas").ToString();
        aleynayas.text = PlayerPrefs.GetInt("aleynayas").ToString();
        canyas.text = PlayerPrefs.GetInt("canyas").ToString();
        fatmayas.text = PlayerPrefs.GetInt("fatmayas").ToString();
        korayyas.text = PlayerPrefs.GetInt("korayyas").ToString();
        zeynepyas.text = PlayerPrefs.GetInt("zeynepyas").ToString();
    }
    public void saglikvemutluluk()
    {
        if (PlayerPrefs.GetInt("saglik") < 0)
        {
            PlayerPrefs.SetInt("saglik", 0);
        }
        if (PlayerPrefs.GetInt("saglik") > 100)
        {
            PlayerPrefs.SetInt("saglik", 100);
        }
        if (PlayerPrefs.GetInt("mutluluk") > 100)
        {
            PlayerPrefs.SetInt("mutluluk", 100);
        }
        if (PlayerPrefs.GetInt("mutluluk") < 0)
        {
            PlayerPrefs.SetInt("mutluluk", 0);
        }


    }
   
    public void kaliteYönetim()
    {
        if (PlayerPrefs.GetInt("beslenme") == 1)
        {
            beslenme1.GetComponent<RectTransform>().DOScale(1, 0.8f);
            beslenme2.GetComponent<RectTransform>().DOScale(0, 0.8f);
            beslenme3.GetComponent<RectTransform>().DOScale(0, 0.8f);
            beslenme0.GetComponent<RectTransform>().DOScale(0, 0.8f);
        }
        else if (PlayerPrefs.GetInt("beslenme") == 2)
        {
            beslenme1.GetComponent<RectTransform>().DOScale(0, 0.8f);
            beslenme2.GetComponent<RectTransform>().DOScale(1, 0.8f);
            beslenme3.GetComponent<RectTransform>().DOScale(0, 0.8f);
            beslenme0.GetComponent<RectTransform>().DOScale(0, 0.8f);
        }
        else if (PlayerPrefs.GetInt("beslenme") == 3)
        {
            beslenme1.GetComponent<RectTransform>().DOScale(0, 0.8f);
            beslenme2.GetComponent<RectTransform>().DOScale(0, 0.8f);
            beslenme3.GetComponent<RectTransform>().DOScale(1, 0.8f);
            beslenme0.GetComponent<RectTransform>().DOScale(0, 0.8f);
        }
        else if (PlayerPrefs.GetInt("beslenme") == 0)
        {
            beslenme1.GetComponent<RectTransform>().DOScale(0, 0.8f);
            beslenme2.GetComponent<RectTransform>().DOScale(0, 0.8f);
            beslenme3.GetComponent<RectTransform>().DOScale(0, 0.8f);
            beslenme0.GetComponent<RectTransform>().DOScale(1, 0.8f);
        }

        if (PlayerPrefs.GetInt("ev") == 1)
        {
            ev1.GetComponent<RectTransform>().DOScale(1, 0.8f);
            ev2.GetComponent<RectTransform>().DOScale(0, 0.8f);
            ev3.GetComponent<RectTransform>().DOScale(0, 0.8f);
            ev0.GetComponent<RectTransform>().DOScale(0, 0.8f);
        }
        else if (PlayerPrefs.GetInt("ev") == 2)
        {
            ev1.GetComponent<RectTransform>().DOScale(0, 0.8f);
            ev2.GetComponent<RectTransform>().DOScale(1, 0.8f);
            ev3.GetComponent<RectTransform>().DOScale(0, 0.8f);
            ev0.GetComponent<RectTransform>().DOScale(0, 0.8f);
        }
        else if (PlayerPrefs.GetInt("ev") == 3)
        {
            ev1.GetComponent<RectTransform>().DOScale(0, 0.8f);
            ev2.GetComponent<RectTransform>().DOScale(0, 0.8f);
            ev3.GetComponent<RectTransform>().DOScale(1, 0.8f);
            ev0.GetComponent<RectTransform>().DOScale(0, 0.8f);
        }
        else if (PlayerPrefs.GetInt("ev") == 0)
        {
            ev1.GetComponent<RectTransform>().DOScale(0, 0.8f);
            ev2.GetComponent<RectTransform>().DOScale(0, 0.8f);
            ev3.GetComponent<RectTransform>().DOScale(0, 0.8f);
            ev0.GetComponent<RectTransform>().DOScale(1, 0.8f);
        }


        if (PlayerPrefs.GetInt("giyinme") == 1)
        {
            giyinme1.GetComponent<RectTransform>().DOScale(1, 0.8f);
            giyinme2.GetComponent<RectTransform>().DOScale(0, 0.8f);
            giyinme3.GetComponent<RectTransform>().DOScale(0, 0.8f);
            giyinme0.GetComponent<RectTransform>().DOScale(0, 0.8f);
        }
        else if (PlayerPrefs.GetInt("giyinme") == 2)
        {
            giyinme1.GetComponent<RectTransform>().DOScale(0, 0.8f);
            giyinme2.GetComponent<RectTransform>().DOScale(1, 0.8f);
            giyinme3.GetComponent<RectTransform>().DOScale(0, 0.8f);
            giyinme0.GetComponent<RectTransform>().DOScale(0, 0.8f);
        }
        else if (PlayerPrefs.GetInt("giyinme") == 3)
        {
            giyinme1.GetComponent<RectTransform>().DOScale(0, 0.8f);
            giyinme2.GetComponent<RectTransform>().DOScale(0, 0.8f);
            giyinme3.GetComponent<RectTransform>().DOScale(1, 0.8f);
            giyinme0.GetComponent<RectTransform>().DOScale(0, 0.8f);
        }
        else if (PlayerPrefs.GetInt("giyinme") == 0)
        {
            giyinme1.GetComponent<RectTransform>().DOScale(0, 0.8f);
            giyinme2.GetComponent<RectTransform>().DOScale(0, 0.8f);
            giyinme3.GetComponent<RectTransform>().DOScale(0, 0.8f);
            giyinme0.GetComponent<RectTransform>().DOScale(1, 0.8f);
            ulasim0.GetComponent<RectTransform>().DOScale(0, 0.8f);
        }

        if (PlayerPrefs.GetInt("ulasim") == 1)
        {
            ulasim1.GetComponent<RectTransform>().DOScale(1, 0.8f);
            ulasim2.GetComponent<RectTransform>().DOScale(0, 0.8f);
            ulasim3.GetComponent<RectTransform>().DOScale(0, 0.8f);
            ulasim0.GetComponent<RectTransform>().DOScale(0, 0.8f);
        }
        else if (PlayerPrefs.GetInt("ulasim") == 2)
        {
            ulasim1.GetComponent<RectTransform>().DOScale(0, 0.8f);
            ulasim2.GetComponent<RectTransform>().DOScale(1, 0.8f);
            ulasim3.GetComponent<RectTransform>().DOScale(0, 0.8f);
            ulasim0.GetComponent<RectTransform>().DOScale(0, 0.8f);
        }
        else if (PlayerPrefs.GetInt("ulasim") == 3)
        {
            ulasim1.GetComponent<RectTransform>().DOScale(0, 0.8f);
            ulasim2.GetComponent<RectTransform>().DOScale(0, 0.8f);
            ulasim3.GetComponent<RectTransform>().DOScale(1, 0.8f);
            ulasim0.GetComponent<RectTransform>().DOScale(0, 0.8f);
        }
        else if (PlayerPrefs.GetInt("ulasim") == 0)
        {
            ulasim1.GetComponent<RectTransform>().DOScale(0, 0.8f);
            ulasim2.GetComponent<RectTransform>().DOScale(0, 0.8f);
            ulasim3.GetComponent<RectTransform>().DOScale(0, 0.8f);
            ulasim0.GetComponent<RectTransform>().DOScale(1, 0.8f);
        }

    }
    public void ailenBakmasin()
    {
        if (PlayerPrefs.GetInt("yas") == 24)
        {
            PlayerPrefs.SetInt("beslenme", 1);
            PlayerPrefs.SetInt("ev", 1);
            PlayerPrefs.SetInt("giyinme", 1);
            PlayerPrefs.SetInt("ulasim", 1);
            gameobce.GetComponent<yasatla>().giderEkle(2000);
            güncelle();
            olayTxt.text = "Ailen artýk sana bakmýyor masraflarýný karþýlamalýsýn (karakter paneline göz at)";
            olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
        }
       



    }

    public void kaliteYönetBeslenme(bool artsinmi)
    {
        if (PlayerPrefs.GetInt("yas")>23)
        {
            int seviye = PlayerPrefs.GetInt("beslenme");
            if (artsinmi == true && seviye < 3)
            {
                seviye++;
                PlayerPrefs.SetInt("beslenme", seviye);
                gameobce.GetComponent<yasatla>().giderEkle(500);


            }
            if (artsinmi == false && seviye > 1)
            {
                seviye--;
                PlayerPrefs.SetInt("beslenme", seviye);
                gameobce.GetComponent<yasatla>().giderEkle(-500);

            }
        }
        else
        {
            olayTxt.text = "Ailen þimdilik sana bakmaya devam ediyor";
            olayPanel.GetComponent<RectTransform>().DOScale(1, 1);
        }



    }

    public void kaliteYönetEv(bool artsinmi)
    {
        if (PlayerPrefs.GetInt("yas") > 23)
        {
            int seviye = PlayerPrefs.GetInt("ev");
            if (artsinmi == true && seviye < 3)
            {
                if (seviye == 2 && PlayerPrefs.GetInt("evsahibi") == 0)
                {
                    olayTxt.text = "Bunun için bir ev satýn almalýsýn";
                    olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
                }
                else
                {
                    seviye++;
                    PlayerPrefs.SetInt("ev", seviye);
                    gameobce.GetComponent<yasatla>().giderEkle(500);

                }

                
            }
            if (artsinmi == false && seviye > 1)
            {
                if (PlayerPrefs.GetInt("evsahibi") == 0)
                {
                    seviye--;
                    PlayerPrefs.SetInt("ev", seviye);
                    gameobce.GetComponent<yasatla>().giderEkle(-500);
                }
                else
                {
                    olayTxt.text = "Bir evin var zaten emin ol buna gerek yok";
                    olayPanel.GetComponent<RectTransform>().DOScale(1, 1);
                }
                

            }
        }
        else
        {
            olayTxt.text = "Ailen þimdilik sana bakmaya devam ediyor";
            olayPanel.GetComponent<RectTransform>().DOScale(1, 1);
        }


    }

    public void kaliteYönetgiyinme(bool artsinmi)
    {
        if (PlayerPrefs.GetInt("yas") > 23)
        {
            int seviye = PlayerPrefs.GetInt("giyinme");
            if (artsinmi == true && seviye < 3)
            {
                seviye++;
                PlayerPrefs.SetInt("giyinme", seviye);
                gameobce.GetComponent<yasatla>().giderEkle(500);

            }
            if (artsinmi == false && seviye > 1)
            {
                seviye--;
                PlayerPrefs.SetInt("giyinme", seviye);
                gameobce.GetComponent<yasatla>().giderEkle(-500);

            }
        }
        else
        {
            olayTxt.text = "Ailen þimdilik sana bakmaya devam ediyor";
            olayPanel.GetComponent<RectTransform>().DOScale(1, 1);
        }


    }

    public void kaliteYönetUlasim(bool artsinmi)
    {
        if (PlayerPrefs.GetInt("yas") > 23)
        {
            int seviye = PlayerPrefs.GetInt("ulasim");
            if (artsinmi == true && seviye < 3)
            {
                if (seviye ==2 && PlayerPrefs.GetInt("araba") ==0)
                {
                    olayTxt.text = "Bunun için bir araba satýn almalýsýn";
                    olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
                }
                else
                {
                    seviye++;
                    PlayerPrefs.SetInt("ulasim", seviye);
                    gameobce.GetComponent<yasatla>().giderEkle(500);

                }
                
            }
            if (artsinmi == false && seviye > 1)
            {
                if (PlayerPrefs.GetInt("araba") == 0)
                {
                    seviye--;
                    PlayerPrefs.SetInt("ulasim", seviye);
                    gameobce.GetComponent<yasatla>().giderEkle(-500);
                }
                else
                {
                    olayTxt.text = "Bir araban var zaten emin ol buna gerek yok";
                    olayPanel.GetComponent<RectTransform>().DOScale(1, 1);
                }
                

            }
        }
        else
        {
            olayTxt.text = "Ailen þimdilik sana bakmaya devam ediyor";
            olayPanel.GetComponent<RectTransform>().DOScale(1, 1);
        }


    }

    public void yüzOluncaKapa()
    {
        if (PlayerPrefs.GetInt("matematik")==100)
        {
            yükseltmeler[0].GetComponent<RectTransform>().DOScale(0, 0.5f);
        }
        if (PlayerPrefs.GetInt("fen") == 100)
        {
            yükseltmeler[1].GetComponent<RectTransform>().DOScale(0, 0.5f);
        }
        if (PlayerPrefs.GetInt("dilBilimleri") == 100)
        {
            yükseltmeler[2].GetComponent<RectTransform>().DOScale(0, 0.5f);
        }
        if (PlayerPrefs.GetInt("sosyalBilimler") == 100)
        {
            yükseltmeler[3].GetComponent<RectTransform>().DOScale(0, 0.5f);
        }
        if (PlayerPrefs.GetInt("karizma") == 100)
        {
            yükseltmeler[5].GetComponent<RectTransform>().DOScale(0, 0.5f);
        }
        if (PlayerPrefs.GetInt("ticaret") == 100)
        {
            yükseltmeler[6].GetComponent<RectTransform>().DOScale(0, 0.5f);
        }
        if (PlayerPrefs.GetInt("resim") == 100)
        {
            yükseltmeler[7].GetComponent<RectTransform>().DOScale(0, 0.5f);
        }
        if (PlayerPrefs.GetInt("müzik") == 100)
        {
            yükseltmeler[8].GetComponent<RectTransform>().DOScale(0, 0.5f);
        }
        if (PlayerPrefs.GetInt("güc") == 100)
        {
            yükseltmeler[9].GetComponent<RectTransform>().DOScale(0, 0.5f);
        }
        if (PlayerPrefs.GetInt("hiz") == 100)
        {
            yükseltmeler[10].GetComponent<RectTransform>().DOScale(0, 0.5f);
        }
        if (PlayerPrefs.GetInt("dayaniklilik") == 100)
        {
            yükseltmeler[11].GetComponent<RectTransform>().DOScale(0, 0.5f);
        }
        if (PlayerPrefs.GetInt("teknik") == 100)
        {
            yükseltmeler[12].GetComponent<RectTransform>().DOScale(0, 0.5f);
        }
    }
    public void yüzeEsitle()
    {
        if (PlayerPrefs.GetInt("matematik") > 100)
        {
            PlayerPrefs.SetInt("matematik", 100);
        }
        if (PlayerPrefs.GetInt("fen") > 100)
        {
            PlayerPrefs.SetInt("fen", 100);
        }
        if (PlayerPrefs.GetInt("dilBilimleri") > 100)
        {
            PlayerPrefs.SetInt("dilBilimleri", 100);
        }
        if (PlayerPrefs.GetInt("sosyalBilimler") > 100)
        {
            PlayerPrefs.SetInt("sosyalBilimler", 100);
        }
        if (PlayerPrefs.GetInt("karizma") > 100)
        {
            PlayerPrefs.SetInt("karizma", 100);
        }
        if (PlayerPrefs.GetInt("ticaret") > 100)
        {
            PlayerPrefs.SetInt("ticaret", 100);
        }
        if (PlayerPrefs.GetInt("resim") > 100)
        {
            PlayerPrefs.SetInt("resim", 100);
        }
        if (PlayerPrefs.GetInt("müzik") > 100)
        {
            PlayerPrefs.SetInt("müzik", 100);
        }
        if (PlayerPrefs.GetInt("güc") > 100)
        {
            PlayerPrefs.SetInt("güc", 100);
        }
        if (PlayerPrefs.GetInt("hiz") > 100)
        {
            PlayerPrefs.SetInt("hiz", 100);
        }
        if (PlayerPrefs.GetInt("dayaniklilik") > 100)
        {
            PlayerPrefs.SetInt("dayaniklilik", 100);
        }
        if (PlayerPrefs.GetInt("teknik") > 100)
        {
            PlayerPrefs.SetInt("teknik", 100);
        }
    }
    public void olayPanelKapat()
    {
        olayPanel.GetComponent<RectTransform>().DOScale(0, 1);
    }
    public void okuldurumunuGüncelle()
    {
        if (PlayerPrefs.GetInt("okulDurumu") ==0)
        {

        }
        else if (PlayerPrefs.GetInt("okulDurumu") < 5)
        {
            OkulTxt1.text = "Okula git (Ýlk okulda okuyorsun) (-5)";
            OkulTxt2.text = "Þuan ilk okulda okuyorsun.";
        }
        else if (PlayerPrefs.GetInt("okulDurumu") <9)
        {
            OkulTxt1.text = "Okula git (Orta okulda okuyorsun) (-5)";
            OkulTxt2.text = "Þuan orta okulda okuyorsun.";
            mezunOkulTxt.text = "Ýlk okul mezunusun";
        }
        else if (PlayerPrefs.GetInt("okulDurumu") < 13)
        {
            OkulTxt1.text = "Okula git (lisede okuyorsun) (-5)";
            OkulTxt2.text = "Þuan meslek lisesinde okuyorsun.";
            mezunOkulTxt.text = "Orta okul mezunusun";
        }
        else if (PlayerPrefs.GetInt("okulDurumu") == 13 && PlayerPrefs.GetInt("üni") ==0)
        {
            OkulTxt1.text = "Üniversite seç";
            OkulTxt2.text = "Þuan okuduðun bir okul yok";
            mezunOkulTxt.text = "Lise mezunusun";
        }
       


    }



}
