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
        StartCoroutine(Yazibüyükücü());
        
    }

    IEnumerator BtnGetir()
    {
        //butonlar sýra ile geliyor.
        yield return new WaitForSeconds(0.5f);
        baslaBtn.GetComponent<RectTransform>().DOScale(1, 0.5f);
        yield return new WaitForSeconds(0.8f);
        DvmBtn.GetComponent<RectTransform>().DOScale(1, 0.5f);
        yield return new WaitForSeconds(1f);
        CikisBtn.GetComponent<RectTransform>().DOScale(1, 0.5f);
    }
    IEnumerator Yazibüyükücü()
    {
       //new life yazýsý sürekli büyüyüp kücülüyor.
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
        //daha önce kayýtlý oyunu varmý diye kontrol ediyorum varsa uyarý panelini açacak.
        uyariPanelKontrol = 1;
        int saveKontrol = PlayerPrefs.GetInt("save");
        if (saveKontrol==1)
        {
            uyariTxt.text = "Kayýtlý oyununuz var yeni oyun tüm kayýtlarý siler. Emin misiniz ?";
            uyariPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
        }
        else
        {
            PlayerPrefs.DeleteAll();
            SceneManager.LoadScene("NewGame");
        }
        
    }
    public void oyunYükle()
    {
        //kayýtlý oyun yoksa açmayacak.
        uyariPanelKontrol = 2;
        int saveKontrol = PlayerPrefs.GetInt("save");
        if (saveKontrol ==0)
        {
            uyariTxt.text = "kayýtlý oyun bulunamadý";
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
        uyariTxt.text = "Çýkmak istediðinize emin misiniz ?";
        uyariPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);

        
    }
    public void uyariPanelOkey()
    {
        //tek fonksyondan ile tüm paneli bir deðiþken yardýmý ile kontrol etme.
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
