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
                    olaytxt.text = "Okuduðun kitap matematik konusunda eðiticiydi. \n +1 matematik ";
                    olayPanel.GetComponent<RectTransform>().DOScale(1, 1);
                    gamemanagers.GetComponent<gameManager>().enerjiEkle(-5);
                }
                else if (sans == 2)
                {
                    int deger = PlayerPrefs.GetInt("sosyalBilimler");
                    deger += 1;
                    PlayerPrefs.SetInt("sosyalBilimler", deger);
                    olaytxt.text = "Okuduðun kitap Sosyal bilimler konusunda eðiticiydi. \n +1 Sosyal bilimler ";
                    olayPanel.GetComponent<RectTransform>().DOScale(1, 1);
                    gamemanagers.GetComponent<gameManager>().enerjiEkle(-5);
                }
                else if (sans == 3)
                {
                    int deger = PlayerPrefs.GetInt("fen");
                    deger += 1;
                    PlayerPrefs.SetInt("fen", deger);
                    olaytxt.text = "Okuduðun kitap Fen bilimleri konusunda eðiticiydi. \n +1 Fen bilimleri ";
                    olayPanel.GetComponent<RectTransform>().DOScale(1, 1);
                    gamemanagers.GetComponent<gameManager>().enerjiEkle(-5);
                }
                else if (sans == 4)
                {
                    int deger = PlayerPrefs.GetInt("dilBilimleri");
                    deger += 1;
                    PlayerPrefs.SetInt("dilBilimleri", deger);
                    olaytxt.text = "Okuduðun kitap Dil bilimleri konusunda eðiticiydi. \n +1 Dil bilimleri ";
                    olayPanel.GetComponent<RectTransform>().DOScale(1, 1);
                    gamemanagers.GetComponent<gameManager>().enerjiEkle(-5);
                }
                else
                {
                    olaytxt.text = "kitap okuma kýsmýnda hata meydana geldi";
                    olayPanel.GetComponent<RectTransform>().DOScale(1, 1);
                }
            }
            else
            {
                olaytxt.text = "önce okuma yazmayý öðrenmen gerek";
                olayPanel.GetComponent<RectTransform>().DOScale(1, 1);
            }
        }
        else
        {
            olaytxt.text = "Yeterli enerji kalmadý";
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
                    olaytxt.text = "Dýþardan takýlýrken sosyalleþtin. \n +1 karizma ";
                    olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
                    gamemanagers.GetComponent<gameManager>().enerjiEkle(-5);
                }
                else
                {
                    int deger = PlayerPrefs.GetInt("ticaret");
                    deger += 1;
                    PlayerPrefs.SetInt("ticaret", deger);
                    olaytxt.text = "Dýþardan gezerken ürünlerin fiyatlarýna dikkat ettin. \n +1 ticaret ";
                    olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
                    gamemanagers.GetComponent<gameManager>().enerjiEkle(-5);
                }
            }
            else
            {
                olaytxt.text = "Dýþarda gezebilmek için yaþýn çok küçük";
                olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
            }

           

        }
        else
        {
            olaytxt.text = "Yeterli enerji kalmadý";
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
                olaytxt.text = "Evde resim çizme yeteneðini geliþtirdin. \n +1 resim ";
                olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
                gamemanagers.GetComponent<gameManager>().enerjiEkle(-5);
            }
            else
            {
                olaytxt.text = " resim çizebilmek için yaþýn çok küçük";
                olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
            }

            
        }
        else
        {
            olaytxt.text = "Yeterli enerji kalmadý";
            olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
        }
    }
    public void enstrümanCal()
    {
       

        if (PlayerPrefs.GetInt("enerji") > 4)
        {
            if (PlayerPrefs.GetInt("yas") > 7)
            {
                int deger = PlayerPrefs.GetInt("müzik");
                deger += 1;
                PlayerPrefs.SetInt("müzik", deger);
                olaytxt.text = "Evde müzik yeteneðini geliþtirdin. \n +1 müzik ";
                olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
                gamemanagers.GetComponent<gameManager>().enerjiEkle(-5);
            }
            else
            {
                olaytxt.text = "Enstrüman çalabilmek için yaþýn çok küçük";
                olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
            }
            
        }
        else
        {
            olaytxt.text = "Yeterli enerji kalmadý";
            olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
        }
    }
    public void agirlikKaldir()
    {
        

        if (PlayerPrefs.GetInt("enerji") > 9)
        {
            if (PlayerPrefs.GetInt("yas") > 9)
            {
                int deger = PlayerPrefs.GetInt("güc");
                deger += 1;
                PlayerPrefs.SetInt("güc", deger);
                olaytxt.text = "Evde su bidonlarý ile aðýrlýk çalýþmasý yaptýn \n +1 güç  ";
                olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
                gamemanagers.GetComponent<gameManager>().enerjiEkle(-10);
            }
            else
            {
                olaytxt.text = "Aðýrlýk çalýþmak için yaþýn çok küçük";
                olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
            }
            
        }
        else
        {
            olaytxt.text = "Yeterli enerji kalmadý";
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
                olaytxt.text = "mahalleden çocuklar ile sokakta top oynadýn \n +1 teknik  ";
                olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
                gamemanagers.GetComponent<gameManager>().enerjiEkle(-10);
            }
            else
            {
                olaytxt.text = "Futbol oynamak için yaþýn çok küçük";
                olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
            }
           
        }
        else
        {
            olaytxt.text = "Yeterli enerji kalmadý";
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
                olaytxt.text = "Sokakta bir güzel terleyene kadar koþu yaptýn \n +1 hýz  ";
                olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
                gamemanagers.GetComponent<gameManager>().enerjiEkle(-10);
            }
            else
            {
                olaytxt.text = "Koþu yapabilmek için yaþýn çok küçük";
                olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
            }
            
        }
        else
        {
            olaytxt.text = "Yeterli enerji kalmadý";
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

                int deger3 = PlayerPrefs.GetInt("güc");
                deger3 += 3;
                PlayerPrefs.SetInt("güc", deger3);
                olaytxt.text = "Evde su bidonlarý ile aðýrlýk çalýþmasý yaptýn \n +1 güç  ";

                int deger4 = PlayerPrefs.GetInt("dayaniklilik");
                deger4 += 3;
                PlayerPrefs.SetInt("dayaniklilik", deger4);
                olaytxt.text = "Evde su bidonlarý ile aðýrlýk çalýþmasý yaptýn \n +1 güç  ";

                olaytxt.text = "100 þýnav, 100 mekik, 100 squat 10 km koþu hemde HER GÜN! \n +3 güç, +3 dayanýklýlýk, +3 hýz, +3 teknik  ";
                olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
                gamemanagers.GetComponent<gameManager>().enerjiEkle(-50);
            }
            else
            {
                olaytxt.text = "Saitama için yaþýn çok küçük";
                olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
            }
            
        }
        else
        {
            olaytxt.text = "Yeterli enerji kalmadý";
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
                olaytxt.text = "Konuþmayý öðrenmen lazým önce";
                olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
            }
        }
        else
        {
            olaytxt.text = "Yeterli enerji kalmadý";
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
                olaytxt.text = "Vaktini en iyi þekilde deðerlendirdin \n +15 mutluluk  ";
                olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
                gamemanagers.GetComponent<gameManager>().enerjiEkle(-5);
            }
            else
            {
                olaytxt.text = "Video oyunlarý için yaþýn çok küçük";
                olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
            }
        }
        else
        {
            olaytxt.text = "Yeterli enerji kalmadý";
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

                    int deger3 = PlayerPrefs.GetInt("güc");
                    deger3 += 1;
                    PlayerPrefs.SetInt("güc", deger3);

                    int deger4 = PlayerPrefs.GetInt("dayaniklilik");
                    deger4 += 1;
                    PlayerPrefs.SetInt("dayaniklilik", deger4);

                    olaytxt.text = "Spor salonunda verimli bir çalýþma gerçekleþtirdin \n +1 güç, +1 dayanýklýlýk, +1 hýz, +1 teknik  ";
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
                olaytxt.text = "görünen o ki 13 yaþ altýný kabul etmiyorlar";
                olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
            }

        }
        else
        {
            olaytxt.text = "Yeterli enerji kalmadý";
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

                    int deger4 = PlayerPrefs.GetInt("müzik");
                    deger4 += 1;
                    PlayerPrefs.SetInt("müzik", deger4);

                    olaytxt.text = "Pek çok sosyal aktivitenin yapýldýðý bir kampa girdin \n +1 karizma, +1 ticaret, +1 resim, +1 müzik  ";
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
                olaytxt.text = "görünen o ki 13 yaþ altýný kabul etmiyorlar";
                olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
            }

        }
        else
        {
            olaytxt.text = "Yeterli enerji kalmadý";
            olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
        }
    }
    public void doktoraGÝt()
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
                    olaytxt.text = "Tedavi gördün \n +10 saðlýk";
                    olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
                }
                else
                {
                    olaytxt.text = "Yeterli enerji kalmadý";
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
            olaytxt.text = "Henüz yaþýn küçük";
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
                    olaytxt.text = "Psikolojik destek aldýn \n +10 mutluluk";
                    olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
                }
                else
                {
                    olaytxt.text = "Yeterli enerji kalmadý";
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
            olaytxt.text = "Henüz yaþýn küçük";
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
                        olaytxt.text = "Bir ev satýn aldýn \n barýnma durumu güncellendi";
                        olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
                        gamemanagers.GetComponent<gameManager>().paraEkle(-800000);
                        gameobjess.GetComponent<yasatla>().giderEkle(-500);
                        PlayerPrefs.SetInt("ev", 3);
                        PlayerPrefs.SetInt("evsahibi", 1);
                        gamemanagers.GetComponent<gameManager>().enerjiEkle(-1);
                        gamemanagers.GetComponent<uptage>().güncelle();
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
            olaytxt.text = "Henüz yaþýn küçük";
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
                        olaytxt.text = "Bir araba satýn aldýn \n ulaþým durumu güncellendi";
                        olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
                        gamemanagers.GetComponent<gameManager>().paraEkle(-200000);
                        gameobjess.GetComponent<yasatla>().giderEkle(-500);
                        PlayerPrefs.SetInt("ulasim", 3);
                        PlayerPrefs.SetInt("araba", 1);
                        gamemanagers.GetComponent<gameManager>().enerjiEkle(-1);
                        gamemanagers.GetComponent<uptage>().güncelle();
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
            olaytxt.text = "Henüz yaþýn küçük";
            olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
        }

        


    }

    public void yatýrýmYap()
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
                        olaytxt.text = "yatýrýmýndan %100 kazanç saðladýn \n +50000TL";
                        olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);

                    }
                    else if (sans == 2)
                    {
                        gamemanagers.GetComponent<gameManager>().paraEkle(37500);
                        olaytxt.text = "yatýrýmýndan %50 kazanç saðladýn \n +37500TL";
                        olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
                    }
                    else if (sans == 3)
                    {
                        gamemanagers.GetComponent<gameManager>().paraEkle(31250);
                        olaytxt.text = "yatýrýmýndan %25 kazanç saðladýn \n +31250";
                        olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
                    }
                    else if (sans == 4)
                    {
                        gamemanagers.GetComponent<gameManager>().paraEkle(25000);
                        olaytxt.text = "yatýrýmýndan kazanç saðlayamadýn fakat ana paraný kurtardýn \n +25000";
                        olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
                    }
                    else if (sans == 5)
                    {
                        gamemanagers.GetComponent<gameManager>().paraEkle(12500);
                        olaytxt.text = "yatýrýmýndan kazanç saðlayamadýn fakat ana paranýn %50'sini kurtardýn \n +12500";
                        olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
                    }
                    else if (sans == 6)
                    {
                        gamemanagers.GetComponent<gameManager>().paraEkle(6250);
                        olaytxt.text = "yatýrýmýndan kazanç saðlayamadýn fakat ana paranýn %25'ni kurtardýn \n +6250";
                        olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
                    }
                    else
                    {
                        olaytxt.text = "yatýrým yap kýsmýnda bir hata oldu";
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
            olaytxt.text = "Henüz yaþýn küçük";
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
                        takimlar.Add("Çupa FK");
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
                            olaytxt.text = "Tebrikler paraný 2'ye katladýn \n +1000TL";
                            olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
                        }
                        else
                        {
                            kimKazanirPanel.GetComponent<RectTransform>().DOScale(0, 0.5f);
                            gamemanagers.GetComponent<gameManager>().paraEkle(1500);
                            olaytxt.text = "Tebrikler paraný 3'e katladýn \n +1500TL";
                            olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
                        }
                        takimlar.Remove("Kartal JK");
                        takimlar.Remove("Aslan SG");
                        takimlar.Remove("Kanarya SK");
                        takimlar.Remove("Çupa FK");


                    }
                    else if (kimKazanir > 0)
                    {
                        kimKazanirPanel.GetComponent<RectTransform>().DOScale(0, 0.5f);
                        olaytxt.text = "Yanlýþ takýmý destekledin paran puff oldu";
                        olayPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
                        takimlar.Remove("Kartal JK");
                        takimlar.Remove("Aslan SG");
                        takimlar.Remove("Kanarya SK");
                        takimlar.Remove("Çupa FK");
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
            olaytxt.text = "Henüz yaþýn küçük";
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
            olaytxt.text = "yaþýn daha küçük";
            olayPanel.GetComponent<RectTransform>().DOScale(1, 0.4f);
        }

        if (acilsin == false)
        {
            sansOyunuPanel.GetComponent<RectTransform>().DOScale(0, 0.4f);
        }
        
    }
    public void bilgiVer()
    {
        olaytxt.text = "Önce üst kýsýmda 1'den 99'a kadar istediðiniz 7 sayýyý giriniz ardýndan baþla butonuna basýnýz. " +
            "Baþla butonuna basýnca 21 rastgele sayý gelecek kaç tane tutarsa o kadar kat para kazanýrsýn.";
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
            olaytxt.text = "Lütfen üst kýsýma sayýlarý giriniz";
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
            olaytxt.text = "Sadece 1 sayý tuttu yatýrdýðýnýz parayý geri aldýnýz";
            olayPanel.GetComponent<RectTransform>().DOScale(1, 0.4f);
            sansOyunuPanel.GetComponent<RectTransform>().DOScale(0, 0.4f);
        }
        else if (tutansayi>1)
        {
            olaytxt.text = "tebrikler toplam " + tutansayi.ToString() + " sayý tutturdunuz kazanýlan para = " + kazanilanPara.ToString();
            olayPanel.GetComponent<RectTransform>().DOScale(1, 0.4f);
            sansOyunuPanel.GetComponent<RectTransform>().DOScale(0, 0.4f);
        }
        else
        {
            olaytxt.text = "Hiç tutturamadýnýz";
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
            olaytxt.text = "Yaþýn henüz çok küçük";
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
                olaytxt.text = "Ýþ bulmadan önce liseyi bitirmelisin.";
            }
           
        }
        else
        {
            isbulPanel.GetComponent<RectTransform>().DOScale(0, 0.3f);
        }
    }
    
}
