using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yetenekManager : MonoBehaviour
{
    public GameObject güncelle;
    public GameObject gamemanagers;
    
    public void matEkle(int miktar)
    {

        if (PlayerPrefs.HasKey("matematik"))
        {
            int deger = PlayerPrefs.GetInt("matematik");
            deger += miktar;
            PlayerPrefs.SetInt("matematik", deger);
        }
        güncelle.GetComponent<uptage>().güncelle();
        gamemanagers.GetComponent<gameManager>().yetenekEkle(-1);

    }

    public void FenEkle(int miktar)
    {

        if (PlayerPrefs.HasKey("fen"))
        {
            int deger = PlayerPrefs.GetInt("fen");
            deger += miktar;
            PlayerPrefs.SetInt("fen", deger);
        }
        güncelle.GetComponent<uptage>().güncelle();
        gamemanagers.GetComponent<gameManager>().yetenekEkle(-1);
    }
    public void dilBilimleriEkle(int miktar)
    {

        if (PlayerPrefs.HasKey("dilBilimleri"))
        {
            int deger = PlayerPrefs.GetInt("dilBilimleri");
            deger += miktar;
            PlayerPrefs.SetInt("dilBilimleri", deger);
        }
        güncelle.GetComponent<uptage>().güncelle();
        gamemanagers.GetComponent<gameManager>().yetenekEkle(-1);
    }
    public void sosyalBilimlerEkle(int miktar)
    {

        if (PlayerPrefs.HasKey("sosyalBilimler"))
        {
            int deger = PlayerPrefs.GetInt("sosyalBilimler");
            deger += miktar;
            PlayerPrefs.SetInt("sosyalBilimler", deger);
        }
        güncelle.GetComponent<uptage>().güncelle();
        gamemanagers.GetComponent<gameManager>().yetenekEkle(-1);
    }

    public void KarizmaEkle(int miktar)
    {

        if (PlayerPrefs.HasKey("karizma"))
        {
            int deger = PlayerPrefs.GetInt("karizma");
            deger += miktar;
            PlayerPrefs.SetInt("karizma", deger);
        }
        güncelle.GetComponent<uptage>().güncelle();
        gamemanagers.GetComponent<gameManager>().yetenekEkle(-1);
    }

    public void ticaretEkle(int miktar)
    {

        if (PlayerPrefs.HasKey("ticaret"))
        {
            int deger = PlayerPrefs.GetInt("ticaret");
            deger += miktar;
            PlayerPrefs.SetInt("ticaret", deger);
        }
        güncelle.GetComponent<uptage>().güncelle();
        gamemanagers.GetComponent<gameManager>().yetenekEkle(-1);
    }

    public void resimEkle(int miktar)
    {

        if (PlayerPrefs.HasKey("resim"))
        {
            int deger = PlayerPrefs.GetInt("resim");
            deger += miktar;
            PlayerPrefs.SetInt("resim", deger);
        }
        güncelle.GetComponent<uptage>().güncelle();
        gamemanagers.GetComponent<gameManager>().yetenekEkle(-1);
    }

    public void müzikEkle(int miktar)
    {

        if (PlayerPrefs.HasKey("müzik"))
        {
            int deger = PlayerPrefs.GetInt("müzik");
            deger += miktar;
            PlayerPrefs.SetInt("müzik", deger);
        }
        güncelle.GetComponent<uptage>().güncelle();
        gamemanagers.GetComponent<gameManager>().yetenekEkle(-1);
    }

    public void gücEkle(int miktar)
    {

        if (PlayerPrefs.HasKey("güc"))
        {
            int deger = PlayerPrefs.GetInt("güc");
            deger += miktar;
            PlayerPrefs.SetInt("güc", deger);
        }
        güncelle.GetComponent<uptage>().güncelle();
        gamemanagers.GetComponent<gameManager>().yetenekEkle(-1);
    }

    public void hizEkle(int miktar)
    {

        if (PlayerPrefs.HasKey("hiz"))
        {
            int deger = PlayerPrefs.GetInt("hiz");
            deger += miktar;
            PlayerPrefs.SetInt("hiz", deger);
        }
        güncelle.GetComponent<uptage>().güncelle();
        gamemanagers.GetComponent<gameManager>().yetenekEkle(-1);
    }

    public void dayaniklilikEkle(int miktar)
    {

        if (PlayerPrefs.HasKey("dayaniklilik"))
        {
            int deger = PlayerPrefs.GetInt("dayaniklilik");
            deger += miktar;
            PlayerPrefs.SetInt("dayaniklilik", deger);
        }
        güncelle.GetComponent<uptage>().güncelle();
        gamemanagers.GetComponent<gameManager>().yetenekEkle(-1);
    }

    public void teknikEkle(int miktar)
    {

        if (PlayerPrefs.HasKey("teknik"))
        {
            int deger = PlayerPrefs.GetInt("teknik");
            deger += miktar;
            PlayerPrefs.SetInt("teknik", deger);
        }
        güncelle.GetComponent<uptage>().güncelle();
        gamemanagers.GetComponent<gameManager>().yetenekEkle(-1);
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
        gamemanagers.GetComponent<gameManager>().yetenekEkle(-1);
    }



}
