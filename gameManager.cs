using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;
public class gameManager : MonoBehaviour
{
    public GameObject studyPanel, speakingPanel, kondisyonPanel, ticaretPanel,aktivitePanel,karakterPaneli;
    void Start()
    {
        
    }
    public void cikis()
    {
        SceneManager.LoadScene("MainScane");
    }
    public void panelAc(int hangiPanel)
    {
        //tek bir void ile tüm butonlarý kontrol ediyorum butondan gelen int deðiþkene göre hareket ediyor
        if (hangiPanel==1)
        {
            studyPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
            speakingPanel.GetComponent<RectTransform>().DOScale(0, 0.5f);
            kondisyonPanel.GetComponent<RectTransform>().DOScale(0, 0.5f);
            ticaretPanel.GetComponent<RectTransform>().DOScale(0, 0.5f);
            aktivitePanel.GetComponent<RectTransform>().DOScale(0, 0.5f);
            karakterPaneli.GetComponent<RectTransform>().DOScale(0, 0.5f);
        }
        else if (hangiPanel == 2)
        {
            studyPanel.GetComponent<RectTransform>().DOScale(0, 0.5f);
            speakingPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
            kondisyonPanel.GetComponent<RectTransform>().DOScale(0, 0.5f);
            ticaretPanel.GetComponent<RectTransform>().DOScale(0, 0.5f);
            aktivitePanel.GetComponent<RectTransform>().DOScale(0, 0.5f);
            karakterPaneli.GetComponent<RectTransform>().DOScale(0, 0.5f);
        }
        else if (hangiPanel == 3)
        {
            studyPanel.GetComponent<RectTransform>().DOScale(0, 0.5f);
            speakingPanel.GetComponent<RectTransform>().DOScale(0, 0.5f);
            kondisyonPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
            ticaretPanel.GetComponent<RectTransform>().DOScale(0, 0.5f);
            aktivitePanel.GetComponent<RectTransform>().DOScale(0, 0.5f);
            karakterPaneli.GetComponent<RectTransform>().DOScale(0, 0.5f);
        }
        else if (hangiPanel == 4)
        {
            studyPanel.GetComponent<RectTransform>().DOScale(0, 0.5f);
            speakingPanel.GetComponent<RectTransform>().DOScale(0, 0.5f);
            kondisyonPanel.GetComponent<RectTransform>().DOScale(0, 0.5f);
            ticaretPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
            aktivitePanel.GetComponent<RectTransform>().DOScale(0, 0.5f);
            karakterPaneli.GetComponent<RectTransform>().DOScale(0, 0.5f);
        }
        else if (hangiPanel == 5)
        {
            studyPanel.GetComponent<RectTransform>().DOScale(0, 0.5f);
            speakingPanel.GetComponent<RectTransform>().DOScale(0, 0.5f);
            kondisyonPanel.GetComponent<RectTransform>().DOScale(0, 0.5f);
            ticaretPanel.GetComponent<RectTransform>().DOScale(0, 0.5f);
            aktivitePanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
            karakterPaneli.GetComponent<RectTransform>().DOScale(0, 0.5f);
        }
        else if (hangiPanel == 6)
        {
            studyPanel.GetComponent<RectTransform>().DOScale(0, 0.5f);
            speakingPanel.GetComponent<RectTransform>().DOScale(0, 0.5f);
            kondisyonPanel.GetComponent<RectTransform>().DOScale(0, 0.5f);
            ticaretPanel.GetComponent<RectTransform>().DOScale(0, 0.5f);
            aktivitePanel.GetComponent<RectTransform>().DOScale(0, 0.5f);
            karakterPaneli.GetComponent<RectTransform>().DOScale(1, 0.5f);
        }

    }
    public void panalKappa()
    {
        // tek fonksiyon'u tüm panel kapama butonlarýna atýyorum.
        studyPanel.GetComponent<RectTransform>().DOScale(0, 0.5f);
        speakingPanel.GetComponent<RectTransform>().DOScale(0, 0.5f);
        kondisyonPanel.GetComponent<RectTransform>().DOScale(0, 0.5f);
        ticaretPanel.GetComponent<RectTransform>().DOScale(0, 0.5f);
        aktivitePanel.GetComponent<RectTransform>().DOScale(0, 0.5f);
        karakterPaneli.GetComponent<RectTransform>().DOScale(0, 0.5f);
    }

}
