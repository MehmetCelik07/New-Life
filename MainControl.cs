using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainControl : MonoBehaviour
{
    public GameObject baslaBtn, DvmBtn, CikisBtn,newLifeImage,uyariPanel;
    public Text uyariTxt;
    int uyariPanelKontrol;

    void Start()
    {
        StartCoroutine(BtnGetir());
        StartCoroutine(Yazib�y�k�c�());
        
    }

    IEnumerator BtnGetir()
    {
        //butonlar s�ra ile geliyor.
        yield return new WaitForSeconds(0.5f);
        baslaBtn.GetComponent<RectTransform>().DOScale(1, 0.5f);
        yield return new WaitForSeconds(0.8f);
        DvmBtn.GetComponent<RectTransform>().DOScale(1, 0.5f);
        yield return new WaitForSeconds(1f);
        CikisBtn.GetComponent<RectTransform>().DOScale(1, 0.5f);
    }
    IEnumerator Yazib�y�k�c�()
    {
       //new life yaz�s� s�rekli b�y�y�p k�c�l�yor.
        while (true)
        {
            newLifeImage.GetComponent<RectTransform>().DOScale(0.8f, 2f);
            yield return new WaitForSeconds(2f);
            newLifeImage.GetComponent<RectTransform>().DOScale(1.5f, 2f);
            yield return new WaitForSeconds(2f);
        }
        
    }
    public void yeniOyun()
    {
        //daha �nce kay�tl� oyunu varm� diye kontrol ediyorum varsa uyar� panelini a�acak.
        uyariPanelKontrol = 1;
        int saveKontrol = PlayerPrefs.GetInt("save");
        if (saveKontrol==1)
        {
            uyariTxt.text = "Kay�tl� oyununuz var yeni oyun t�m kay�tlar� siler. Emin misiniz ?";
            uyariPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
        }
        else
        {
            PlayerPrefs.DeleteAll();
            SceneManager.LoadScene("NewGame");
        }
        
    }
    public void oyunY�kle()
    {
        //kay�tl� oyun yoksa a�mayacak.
        uyariPanelKontrol = 2;
        int saveKontrol = PlayerPrefs.GetInt("save");
        if (saveKontrol ==0)
        {
            uyariTxt.text = "kay�tl� oyun bulunamad�";
            uyariPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
        }
        else
        {
            SceneManager.LoadScene("GameLevel");
        }
        
    }
    public void cikis()
    {
        uyariPanelKontrol = 3;
        uyariTxt.text = "��kmak istedi�inize emin misiniz ?";
        uyariPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);

        
    }
    public void uyariPanelOkey()
    {
        //tek fonksyondan ile t�m paneli bir de�i�ken yard�m� ile kontrol etme.
        if (uyariPanelKontrol==1)
        {
            PlayerPrefs.DeleteAll();
            SceneManager.LoadScene("NewGame");
        }
        else if (uyariPanelKontrol==2)
        {
            uyariPanel.GetComponent<RectTransform>().DOScale(0, 0.5f);
        }
        else if (uyariPanelKontrol ==3)
        {
            Application.Quit();
        }
        
    }
    public void uyariPanelred()
    {
        uyariPanel.GetComponent<RectTransform>().DOScale(0, 0.5f);
    }

}
