using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
public class aktivite : MonoBehaviour
{
    public Text olaytxt,takim1,takim2;
    public GameObject olayPanel,kimKazanirPanel,sansOyunuPanel,carkPanel,isbulPanel;
    public GameObject gamemanagers,gameobjess;
    public List<string> takimlar;
    public List<Text> sayilar;
    public int sans,tutansayi;
    public Text input1, input2, input3, input4, input5, input6, input7;
    int[] rastgeleSayilar = new int[21];
    public void kitapOku()
    {
        if (PlayerPrefs.GetInt("enerji")>4)
        {
            if (PlayerPrefs.GetInt("yas") > 7)
            {
                int sans = Random.Range(1, 5);
                if (sans == 1)
                {
                    int deger = PlayerPrefs.GetInt("matematik");
                    deger += 1;
                    PlayerPrefs.SetInt("matematik", deger);
                    olaytxt.text = "Okudu�un kitap matematik konusunda e�iticiydi. \n +1 matematik ";
                    olayPanel.GetComponent<RectTransform>().DOScale(1, 1);
                    gamemanagers.GetComponent<gameManager>().enerjiEkle(-5);
                }
                else if (sans == 2)
                {
                    int deger = PlayerPrefs.GetInt("sosyalBilimler");
                    deger += 1;
                    PlayerPrefs.SetInt("sosyalBilimler", deger);
                    olaytxt.text = "Okudu�un kitap Sosyal bilimler konusunda e�iticiydi. \n +1 Sosyal bilimler ";
                    olayPanel.GetComponent<RectTransform>().DOScale(1, 1);
                    gamemanagers.GetComponent<gameManager>().enerjiEkle(-5);
                }
                else if (sans == 3)
                {
                    int deger = PlayerPrefs.GetInt("fen");
                    deger += 1;
                    PlayerPrefs.SetInt("fen", deger);
                    olaytxt.text = "Okudu�un kitap Fen bilimleri konusunda e�iticiydi. \n +1 Fen bilimleri ";
                    olayPanel.GetComponent<RectTransform>().DOScale(1, 1);
                    gamemanagers.GetComponent<gameManager>().enerjiEkle(-5);
                }
                else if (sans == 4)
                {
                    int deger = PlayerPrefs.GetInt("dilBilimleri");
                    deger += 1;
                    PlayerPrefs.SetInt("dilBilimleri", deger);
                    olaytxt.text = "Okudu�un kitap Dil bilimleri konusunda e�iticiydi. \n +1 Dil bilimleri ";
                    olayPanel.GetComponent<RectTransform>().DOScale(1, 1);
                    gamemanagers.GetComponent<gameManager>().enerjiEkle(-5);
                }
                else
                {
                    olaytxt.text = "kitap okuma k�sm�nda hata meydana geldi";
                    olayPanel.GetComponent<RectTransform>().DOScale(1, 1);
                }
            }
            else
            {
                olaytxt.text = "�nce okuma yazmay� ��renmen gerek";
                olayPanel.GetComponent<RectTransform>().DOScale(1, 1);
            }
        }
        else
        {
            olaytxt.text = "Yeterli enerji kalmad�";
            olayPanel.GetComponent<RectTransform>().DOScale(1, 1);
        }
       
    }
    public void disardaGez()
    {
        if (PlayerPrefs.GetInt("enerji") > 4)
        {
            if (PlayerPrefs.GetInt("yas")>7)
            {
                int sans = Random.Range(1, 3);
                if (sans == 1)
                {
                    int deger = PlayerPrefs.GetInt("karizma");
                    deger += 1;
                    PlayerPrefs.SetInt("karizma", deger);
                    olaytxt.text = "D��ardan tak�l�rken sosyalle�tin. \n +1 karizma ";
                    olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
                    gamemanagers.GetComponent<gameManager>().enerjiEkle(-5);
                }
                else
                {
                    int deger = PlayerPrefs.GetInt("ticaret");
                    deger += 1;
                    PlayerPrefs.SetInt("ticaret", deger);
                    olaytxt.text = "D��ardan gezerken �r�nlerin fiyatlar�na dikkat ettin. \n +1 ticaret ";
                    olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
                    gamemanagers.GetComponent<gameManager>().enerjiEkle(-5);
                }
            }
            else
            {
                olaytxt.text = "D��arda gezebilmek i�in ya��n �ok k���k";
                olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
            }

           

        }
        else
        {
            olaytxt.text = "Yeterli enerji kalmad�";
            olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
        }
    }
    public void resimYap()
    {
        if (PlayerPrefs.GetInt("enerji") > 4)
        {
            if (PlayerPrefs.GetInt("yas") > 7)
            {
                int deger = PlayerPrefs.GetInt("resim");
                deger += 1;
                PlayerPrefs.SetInt("resim", deger);
                olaytxt.text = "Evde resim �izme yetene�ini geli�tirdin. \n +1 resim ";
                olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
                gamemanagers.GetComponent<gameManager>().enerjiEkle(-5);
            }
            else
            {
                olaytxt.text = " resim �izebilmek i�in ya��n �ok k���k";
                olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
            }

            
        }
        else
        {
            olaytxt.text = "Yeterli enerji kalmad�";
            olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
        }
    }
    public void enstr�manCal()
    {
       

        if (PlayerPrefs.GetInt("enerji") > 4)
        {
            if (PlayerPrefs.GetInt("yas") > 7)
            {
                int deger = PlayerPrefs.GetInt("m�zik");
                deger += 1;
                PlayerPrefs.SetInt("m�zik", deger);
                olaytxt.text = "Evde m�zik yetene�ini geli�tirdin. \n +1 m�zik ";
                olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
                gamemanagers.GetComponent<gameManager>().enerjiEkle(-5);
            }
            else
            {
                olaytxt.text = "Enstr�man �alabilmek i�in ya��n �ok k���k";
                olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
            }
            
        }
        else
        {
            olaytxt.text = "Yeterli enerji kalmad�";
            olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
        }
    }
    public void agirlikKaldir()
    {
        

        if (PlayerPrefs.GetInt("enerji") > 9)
        {
            if (PlayerPrefs.GetInt("yas") > 9)
            {
                int deger = PlayerPrefs.GetInt("g�c");
                deger += 1;
                PlayerPrefs.SetInt("g�c", deger);
                olaytxt.text = "Evde su bidonlar� ile a��rl�k �al��mas� yapt�n \n +1 g��  ";
                olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
                gamemanagers.GetComponent<gameManager>().enerjiEkle(-10);
            }
            else
            {
                olaytxt.text = "A��rl�k �al��mak i�in ya��n �ok k���k";
                olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
            }
            
        }
        else
        {
            olaytxt.text = "Yeterli enerji kalmad�";
            olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
        }
    }
    public void futbolOyna()
    {
       

        if (PlayerPrefs.GetInt("enerji") > 9)
        {
            if (PlayerPrefs.GetInt("yas") > 7)
            {
                int deger = PlayerPrefs.GetInt("teknik");
                deger += 1;
                PlayerPrefs.SetInt("teknik", deger);
                olaytxt.text = "mahalleden �ocuklar ile sokakta top oynad�n \n +1 teknik  ";
                olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
                gamemanagers.GetComponent<gameManager>().enerjiEkle(-10);
            }
            else
            {
                olaytxt.text = "Futbol oynamak i�in ya��n �ok k���k";
                olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
            }
           
        }
        else
        {
            olaytxt.text = "Yeterli enerji kalmad�";
            olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
        }
    }
    public void kosuYap()
    {
       

        if (PlayerPrefs.GetInt("enerji") > 9)
        {
            if (PlayerPrefs.GetInt("yas") > 7)
            {
                int deger = PlayerPrefs.GetInt("hiz");
                deger += 1;
                PlayerPrefs.SetInt("hiz", deger);
                olaytxt.text = "Sokakta bir g�zel terleyene kadar ko�u yapt�n \n +1 h�z  ";
                olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
                gamemanagers.GetComponent<gameManager>().enerjiEkle(-10);
            }
            else
            {
                olaytxt.text = "Ko�u yapabilmek i�in ya��n �ok k���k";
                olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
            }
            
        }
        else
        {
            olaytxt.text = "Yeterli enerji kalmad�";
            olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
        }
    }
    public void saitama()
    {
        

        if (PlayerPrefs.GetInt("enerji") > 49)
        {
            if (PlayerPrefs.GetInt("yas") > 14)
            {
                int deger = PlayerPrefs.GetInt("hiz");
                deger += 3;
                PlayerPrefs.SetInt("hiz", deger);

                int deger2 = PlayerPrefs.GetInt("teknik");
                deger2 += 3;
                PlayerPrefs.SetInt("teknik", deger2);

                int deger3 = PlayerPrefs.GetInt("g�c");
                deger3 += 3;
                PlayerPrefs.SetInt("g�c", deger3);
                olaytxt.text = "Evde su bidonlar� ile a��rl�k �al��mas� yapt�n \n +1 g��  ";

                int deger4 = PlayerPrefs.GetInt("dayaniklilik");
                deger4 += 3;
                PlayerPrefs.SetInt("dayaniklilik", deger4);
                olaytxt.text = "Evde su bidonlar� ile a��rl�k �al��mas� yapt�n \n +1 g��  ";

                olaytxt.text = "100 ��nav, 100 mekik, 100 squat 10 km ko�u hemde HER G�N! \n +3 g��, +3 dayan�kl�l�k, +3 h�z, +3 teknik  ";
                olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
                gamemanagers.GetComponent<gameManager>().enerjiEkle(-50);
            }
            else
            {
                olaytxt.text = "Saitama i�in ya��n �ok k���k";
                olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
            }
            
        }
        else
        {
            olaytxt.text = "Yeterli enerji kalmad�";
            olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
        }
    }
    public void filmizle()
    {
        if (PlayerPrefs.GetInt("enerji") > 4)
        {
            if (PlayerPrefs.GetInt("yas") > 3)
            {
                int deger = PlayerPrefs.GetInt("mutluluk");
                deger += 5;
                PlayerPrefs.SetInt("mutluluk", deger);
                olaytxt.text = "Kaliteli bir film izledin. \n +5 mutluluk  ";
                olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
                gamemanagers.GetComponent<gameManager>().enerjiEkle(-5);
            }
            else
            {
                olaytxt.text = "Konu�may� ��renmen laz�m �nce";
                olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
            }
        }
        else
        {
            olaytxt.text = "Yeterli enerji kalmad�";
            olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
        }
    }
    public void oyunOyna()
    {
        if (PlayerPrefs.GetInt("enerji") > 9)
        {
            if (PlayerPrefs.GetInt("yas") > 6)
            {
                int deger = PlayerPrefs.GetInt("mutluluk");
                deger += 15;
                PlayerPrefs.SetInt("mutluluk", deger);
                olaytxt.text = "Vaktini en iyi �ekilde de�erlendirdin \n +15 mutluluk  ";
                olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
                gamemanagers.GetComponent<gameManager>().enerjiEkle(-5);
            }
            else
            {
                olaytxt.text = "Video oyunlar� i�in ya��n �ok k���k";
                olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
            }
        }
        else
        {
            olaytxt.text = "Yeterli enerji kalmad�";
            olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
        }
    }
    public void sporSalanu()
    {
        if (PlayerPrefs.GetInt("enerji") > 9)
        {
            if (PlayerPrefs.GetInt("yas") > 12)
            {
                if (PlayerPrefs.GetInt("para") >= 1000)
                {
                    int deger = PlayerPrefs.GetInt("hiz");
                    deger += 1;
                    PlayerPrefs.SetInt("hiz", deger);

                    int deger2 = PlayerPrefs.GetInt("teknik");
                    deger2 += 1;
                    PlayerPrefs.SetInt("teknik", deger2);

                    int deger3 = PlayerPrefs.GetInt("g�c");
                    deger3 += 1;
                    PlayerPrefs.SetInt("g�c", deger3);

                    int deger4 = PlayerPrefs.GetInt("dayaniklilik");
                    deger4 += 1;
                    PlayerPrefs.SetInt("dayaniklilik", deger4);

                    olaytxt.text = "Spor salonunda verimli bir �al��ma ger�ekle�tirdin \n +1 g��, +1 dayan�kl�l�k, +1 h�z, +1 teknik  ";
                    olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
                    gamemanagers.GetComponent<gameManager>().enerjiEkle(-10);
                    gamemanagers.GetComponent<gameManager>().paraEkle(-1000);
                }
                else
                {
                    olaytxt.text = "yeterli paran yok";
                    olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
                }

               
            }
            else
            {
                olaytxt.text = "g�r�nen o ki 13 ya� alt�n� kabul etmiyorlar";
                olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
            }

        }
        else
        {
            olaytxt.text = "Yeterli enerji kalmad�";
            olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
        }
    }
    public void KampaGit()
    {
        if (PlayerPrefs.GetInt("enerji") > 9)
        {
            if (PlayerPrefs.GetInt("yas") > 12)
            {
                if (PlayerPrefs.GetInt("para") >= 1000)
                {
                    int deger = PlayerPrefs.GetInt("karizma");
                    deger += 1;
                    PlayerPrefs.SetInt("karizma", deger);

                    int deger2 = PlayerPrefs.GetInt("ticaret");
                    deger2 += 1;
                    PlayerPrefs.SetInt("ticaret", deger2);

                    int deger3 = PlayerPrefs.GetInt("resim");
                    deger3 += 1;
                    PlayerPrefs.SetInt("resim", deger3);

                    int deger4 = PlayerPrefs.GetInt("m�zik");
                    deger4 += 1;
                    PlayerPrefs.SetInt("m�zik", deger4);

                    olaytxt.text = "Pek �ok sosyal aktivitenin yap�ld��� bir kampa girdin \n +1 karizma, +1 ticaret, +1 resim, +1 m�zik  ";
                    olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
                    gamemanagers.GetComponent<gameManager>().enerjiEkle(-10);
                    gamemanagers.GetComponent<gameManager>().paraEkle(-1000);
                }
                else
                {
                    olaytxt.text = "Yeterli paran yok";
                    olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
                }
               
            }
            else
            {
                olaytxt.text = "g�r�nen o ki 13 ya� alt�n� kabul etmiyorlar";
                olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
            }

        }
        else
        {
            olaytxt.text = "Yeterli enerji kalmad�";
            olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
        }
    }
    public void doktoraG�t()
    {
        if (PlayerPrefs.GetInt("yas") > 5)
        {
            if (PlayerPrefs.GetInt("para") >= 5000)
            {

                if (PlayerPrefs.GetInt("enerji") > 0)
                {

                    gameobjess.GetComponent<yasatla>().saglikekle(10);
                    gamemanagers.GetComponent<gameManager>().paraEkle(-5000);
                    gamemanagers.GetComponent<gameManager>().enerjiEkle(-1);
                    olaytxt.text = "Tedavi g�rd�n \n +10 sa�l�k";
                    olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
                }
                else
                {
                    olaytxt.text = "Yeterli enerji kalmad�";
                    olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
                }
            }
            else
            {
                olaytxt.text = "Yeterli paran yok";
                olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
            }
        }
        else
        {
            olaytxt.text = "Hen�z ya��n k���k";
            olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
        }


    }
    public void psikologGit()
    {
        if (PlayerPrefs.GetInt("yas") > 5)
        {
            if (PlayerPrefs.GetInt("para") >= 5000)
            {
                if (PlayerPrefs.GetInt("enerji") > 0)
                {

                    gamemanagers.GetComponent<gameManager>().paraEkle(-5000);
                    gamemanagers.GetComponent<gameManager>().mutlulukEkle(10);
                    gamemanagers.GetComponent<gameManager>().enerjiEkle(-1);
                    olaytxt.text = "Psikolojik destek ald�n \n +10 mutluluk";
                    olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
                }
                else
                {
                    olaytxt.text = "Yeterli enerji kalmad�";
                    olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
                }
            }
            else
            {
                olaytxt.text = "Yeterli paran yok";
                olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
            }
        }
        else
        {
            olaytxt.text = "Hen�z ya��n k���k";
            olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
        }

       
    }
    public void Eval()
    {
        if (PlayerPrefs.GetInt("yas") > 17)
        {
            if (PlayerPrefs.GetInt("para") >= 800000)
            {
                if (PlayerPrefs.GetInt("enerji") > 0)
                {
                    if (PlayerPrefs.GetInt("evsahibi") == 0)
                    {
                        olaytxt.text = "Bir ev sat�n ald�n \n bar�nma durumu g�ncellendi";
                        olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
                        gamemanagers.GetComponent<gameManager>().paraEkle(-800000);
                        gameobjess.GetComponent<yasatla>().giderEkle(-500);
                        PlayerPrefs.SetInt("ev", 3);
                        PlayerPrefs.SetInt("evsahibi", 1);
                        gamemanagers.GetComponent<gameManager>().enerjiEkle(-1);
                        gamemanagers.GetComponent<uptage>().g�ncelle();
                    }
                    else
                    {
                        olaytxt.text = "zaten bir evin var";
                        olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
                    }

                }
                else
                {
                    olaytxt.text = "Yeterli enerji yok";
                    olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
                }

            }
            else
            {
                olaytxt.text = "Yeterli paran yok";
                olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
            }
        }
        else
        {
            olaytxt.text = "Hen�z ya��n k���k";
            olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
        }

        

    }
    public void ArabaAl()
    {
        if (PlayerPrefs.GetInt("yas") > 17)
        {
            if (PlayerPrefs.GetInt("para") >= 200000)
            {
                if (PlayerPrefs.GetInt("enerji") > 0)
                {
                    if (PlayerPrefs.GetInt("araba") == 0)
                    {
                        olaytxt.text = "Bir araba sat�n ald�n \n ula��m durumu g�ncellendi";
                        olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
                        gamemanagers.GetComponent<gameManager>().paraEkle(-200000);
                        gameobjess.GetComponent<yasatla>().giderEkle(-500);
                        PlayerPrefs.SetInt("ulasim", 3);
                        PlayerPrefs.SetInt("araba", 1);
                        gamemanagers.GetComponent<gameManager>().enerjiEkle(-1);
                        gamemanagers.GetComponent<uptage>().g�ncelle();
                    }
                    else
                    {
                        olaytxt.text = "zaten bir araban var";
                        olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
                    }


                }
                else
                {
                    olaytxt.text = "Yeterli enerji yok";
                    olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
                }
            }
            else
            {
                olaytxt.text = "Yeterli paran yok";
                olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
            }
        }
        else
        {
            olaytxt.text = "Hen�z ya��n k���k";
            olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
        }

        


    }

    public void yat�r�mYap()
    {
        if (PlayerPrefs.GetInt("yas") > 17)
        {
            if (PlayerPrefs.GetInt("para") > 24999)
            {
                if (PlayerPrefs.GetInt("enerji") > 9)
                {
                    gamemanagers.GetComponent<gameManager>().enerjiEkle(-10);
                    gamemanagers.GetComponent<gameManager>().paraEkle(-25000);
                    int ticaret = (102 - PlayerPrefs.GetInt("ticaret")) / 15;
                    if (ticaret < 2)
                    {
                        ticaret = 2;
                    }
                    Debug.Log(ticaret);
                    int sans = Random.Range(1, ticaret + 1);

                    if (sans == 1)
                    {
                        gamemanagers.GetComponent<gameManager>().paraEkle(50000);
                        olaytxt.text = "yat�r�m�ndan %100 kazan� sa�lad�n \n +50000TL";
                        olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);

                    }
                    else if (sans == 2)
                    {
                        gamemanagers.GetComponent<gameManager>().paraEkle(37500);
                        olaytxt.text = "yat�r�m�ndan %50 kazan� sa�lad�n \n +37500TL";
                        olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
                    }
                    else if (sans == 3)
                    {
                        gamemanagers.GetComponent<gameManager>().paraEkle(31250);
                        olaytxt.text = "yat�r�m�ndan %25 kazan� sa�lad�n \n +31250";
                        olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
                    }
                    else if (sans == 4)
                    {
                        gamemanagers.GetComponent<gameManager>().paraEkle(25000);
                        olaytxt.text = "yat�r�m�ndan kazan� sa�layamad�n fakat ana paran� kurtard�n \n +25000";
                        olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
                    }
                    else if (sans == 5)
                    {
                        gamemanagers.GetComponent<gameManager>().paraEkle(12500);
                        olaytxt.text = "yat�r�m�ndan kazan� sa�layamad�n fakat ana paran�n %50'sini kurtard�n \n +12500";
                        olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
                    }
                    else if (sans == 6)
                    {
                        gamemanagers.GetComponent<gameManager>().paraEkle(6250);
                        olaytxt.text = "yat�r�m�ndan kazan� sa�layamad�n fakat ana paran�n %25'ni kurtard�n \n +6250";
                        olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
                    }
                    else
                    {
                        olaytxt.text = "yat�r�m yap k�sm�nda bir hata oldu";
                        olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
                    }
                }
                else
                {
                    olaytxt.text = "Yeterli enerji yok";
                    olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
                }
            }
            else
            {
                olaytxt.text = "Yeterli paran yok";
                olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
            }
        }
        else
        {
            olaytxt.text = "Hen�z ya��n k���k";
            olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
        }
       
    }
    public void hile()
    {
        gamemanagers.GetComponent<gameManager>().enerjiEkle(100);
        gamemanagers.GetComponent<gameManager>().paraEkle(100000);
    }
    public void iddaaOyna(int kimKazanir)
    {

        if (PlayerPrefs.GetInt("yas")>17)
        {
            if (PlayerPrefs.GetInt("para") > 499)
            {
                if (PlayerPrefs.GetInt("enerji") > 0)
                {
                    if (kimKazanir == 0)
                    {
                        gamemanagers.GetComponent<gameManager>().paraEkle(-500);
                        takimlar.Add("Kartal JK");
                        takimlar.Add("Aslan SG");
                        takimlar.Add("Kanarya SK");
                        takimlar.Add("�upa FK");
                        int rastgele1 = Random.Range(0, takimlar.Count);
                        string ilkTakim = takimlar[rastgele1];
                        takimlar.Remove(ilkTakim);
                        int rastgele2 = Random.Range(0, takimlar.Count);
                        string ikinciTakim = takimlar[rastgele2];
                        takimlar.Add(ilkTakim);
                        takim1.text = ilkTakim;
                        takim2.text = ikinciTakim;
                        kimKazanirPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
                        sans = Random.Range(1, 3);

                    }
                    if (sans == kimKazanir)
                    {
                        int kazancOrani = Random.Range(1, 3);
                        if (kazancOrani == 1)
                        {
                            kimKazanirPanel.GetComponent<RectTransform>().DOScale(0, 0.5f);
                            gamemanagers.GetComponent<gameManager>().paraEkle(1000);
                            olaytxt.text = "Tebrikler paran� 2'ye katlad�n \n +1000TL";
                            olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
                        }
                        else
                        {
                            kimKazanirPanel.GetComponent<RectTransform>().DOScale(0, 0.5f);
                            gamemanagers.GetComponent<gameManager>().paraEkle(1500);
                            olaytxt.text = "Tebrikler paran� 3'e katlad�n \n +1500TL";
                            olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
                        }
                        takimlar.Remove("Kartal JK");
                        takimlar.Remove("Aslan SG");
                        takimlar.Remove("Kanarya SK");
                        takimlar.Remove("�upa FK");


                    }
                    else if (kimKazanir > 0)
                    {
                        kimKazanirPanel.GetComponent<RectTransform>().DOScale(0, 0.5f);
                        olaytxt.text = "Yanl�� tak�m� destekledin paran puff oldu";
                        olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
                        takimlar.Remove("Kartal JK");
                        takimlar.Remove("Aslan SG");
                        takimlar.Remove("Kanarya SK");
                        takimlar.Remove("�upa FK");
                    }
                }
                else
                {
                    olaytxt.text = "Yeterli enerjin yok";
                    olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
                }
            }
            else
            {
                olaytxt.text = "Yeterli paran yok";
                olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
            }
        }
        else
        {
            olaytxt.text = "Hen�z ya��n k���k";
            olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
        }
      
        

    }
    public void sansOyunupanelAc(bool acilsin)
    {

        if (PlayerPrefs.GetInt("yas")>17)
        {
            if (PlayerPrefs.GetInt("para") > 999)
            {
                if (PlayerPrefs.GetInt("enerji") > 0)
                {
                    if (acilsin)
                    {
                        foreach (var item in sayilar)
                        {
                            item.text = " ";
                        }
                     

                        sansOyunuPanel.GetComponent<RectTransform>().DOScale(1, 0.4f);
                    }
                }
                else
                {
                    olaytxt.text = "yeterli enerjin yok";
                    olayPanel.GetComponent<RectTransform>().DOScale(1, 0.4f);
                }
            }
            else
            {
                olaytxt.text = "yeterli paran yok";
                olayPanel.GetComponent<RectTransform>().DOScale(1, 0.4f);
            }
        }
        else
        {
            olaytxt.text = "ya��n daha k���k";
            olayPanel.GetComponent<RectTransform>().DOScale(1, 0.4f);
        }

        if (acilsin == false)
        {
            sansOyunuPanel.GetComponent<RectTransform>().DOScale(0, 0.4f);
        }
        
    }
    public void bilgiVer()
    {
        olaytxt.text = "�nce �st k�s�mda 1'den 99'a kadar istedi�iniz 7 say�y� giriniz ard�ndan ba�la butonuna bas�n�z. " +
            "Ba�la butonuna bas�nca 21 rastgele say� gelecek ka� tane tutarsa o kadar kat para kazan�rs�n.";
        olayPanel.GetComponent<RectTransform>().DOScale(1, 0.4f);

    }
    public void sansOyunuBaslat()
    {
        tutansayi = 0;
        try
        {
            int gelen1, gelen2, gelen3, gelen4, gelen5, gelen6, gelen7;
            gelen1 = int.Parse(input1.text);
            gelen2 = int.Parse(input2.text);
            gelen3 = int.Parse(input3.text);
            gelen4 = int.Parse(input4.text);
            gelen5 = int.Parse(input5.text);
            gelen6 = int.Parse(input6.text);
            gelen7 = int.Parse(input7.text);
            for (int i = 0; i < 21; i++)
            {
                int rastgele = Random.Range(1, 100);
                rastgeleSayilar[i] = rastgele;

            }
           
            for (int i = 0; i < 21; i++)
            {
                if (rastgeleSayilar[i] ==gelen1)
                {
                    tutansayi++;
                }
                if (rastgeleSayilar[i] == gelen2)
                {
                    tutansayi++;
                }
                if (rastgeleSayilar[i] == gelen3)
                {
                    tutansayi++;
                }
                if (rastgeleSayilar[i] == gelen4)
                {
                    tutansayi++;
                }
                if (rastgeleSayilar[i] == gelen5)
                {
                    tutansayi++;
                }
                if (rastgeleSayilar[i] == gelen6)
                {
                    tutansayi++;
                }
                if (rastgeleSayilar[i] == gelen7)
                {
                    tutansayi++;
                }
            }
            StartCoroutine(sayilariGetir());
        }
        catch (System.Exception)
        {
            olaytxt.text = "L�tfen �st k�s�ma say�lar� giriniz";
            olayPanel.GetComponent<RectTransform>().DOScale(1, 0.4f);
            
        }
        
        
        

    }
    IEnumerator sayilariGetir()
    {
        for (int i = 0; i < 21; i++)
        {
            sayilar[i].text = rastgeleSayilar[i].ToString();
            yield return new WaitForSeconds(0.25f);
        }
        yield return new WaitForSeconds(1);
        int kazanilanPara = 1000 * tutansayi;
        gamemanagers.GetComponent<gameManager>().paraEkle(kazanilanPara);

        if (tutansayi ==1)
        {
            olaytxt.text = "Sadece 1 say� tuttu yat�rd���n�z paray� geri ald�n�z";
            olayPanel.GetComponent<RectTransform>().DOScale(1, 0.4f);
            sansOyunuPanel.GetComponent<RectTransform>().DOScale(0, 0.4f);
        }
        else if (tutansayi>1)
        {
            olaytxt.text = "tebrikler toplam " + tutansayi.ToString() + " say� tutturdunuz kazan�lan para = " + kazanilanPara.ToString();
            olayPanel.GetComponent<RectTransform>().DOScale(1, 0.4f);
            sansOyunuPanel.GetComponent<RectTransform>().DOScale(0, 0.4f);
        }
        else
        {
            olaytxt.text = "Hi� tutturamad�n�z";
            olayPanel.GetComponent<RectTransform>().DOScale(1, 0.4f);
            sansOyunuPanel.GetComponent<RectTransform>().DOScale(0, 0.4f);
        }

    }

    public void carkBaslat()
    {
        if (PlayerPrefs.GetInt("yas")>9)
        {
            if (PlayerPrefs.GetInt("enerji") > 0)
            {

                if (PlayerPrefs.GetInt("para") > 999)
                {
                    carkPanel.GetComponent<RectTransform>().DOScale(1, 0.4f);
                }
                else
                {
                    olaytxt.text = "Yeterli para yok";
                    olayPanel.GetComponent<RectTransform>().DOScale(1, 0.4f);
                }
            }
            else
            {
                olaytxt.text = "Yeterli enerji yok";
                olayPanel.GetComponent<RectTransform>().DOScale(1, 0.4f);
            }
        }
        else
        {
            olaytxt.text = "Ya��n hen�z �ok k���k";
            olayPanel.GetComponent<RectTransform>().DOScale(1, 0.4f);
        }
    }
    public void isbulPanelAcKapa(bool acilsin)
    {
        if (acilsin)
        {
            if (PlayerPrefs.GetInt("okulDurumu")>12)
            {
                isbulPanel.GetComponent<RectTransform>().DOScale(1, 0.3f);
            }
            else
            {
                olayPanel.GetComponent<RectTransform>().DOScale(1, 0.3f);
                olaytxt.text = "�� bulmadan �nce liseyi bitirmelisin.";
            }
           
        }
        else
        {
            isbulPanel.GetComponent<RectTransform>().DOScale(0, 0.3f);
        }
    }
    
}
