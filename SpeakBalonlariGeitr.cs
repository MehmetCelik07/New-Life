using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System;

public class SpeakBalonlariGeitr : MonoBehaviour
{
    public GameObject sosyalAktivitiPanel;
    public GameObject BabaKarakter, AnneKarakter, AhmetKarakter, AleynaKarakter, cankarakter, fatmaKarakter, korayKarakter, zeynepKarakter;
    
    
    public void balonlariAc(int hangi)
    {
        if (hangi ==1)
        {
            BabaKarakter.GetComponent<RectTransform>().DOScale(1, 0.3f);
        }
        else if (hangi == 2)
        {
            AnneKarakter.GetComponent<RectTransform>().DOScale(1, 0.3f);
        }
        else if (hangi == 3)
        {
            AhmetKarakter.GetComponent<RectTransform>().DOScale(1, 0.3f);
        }
        else if (hangi == 4)
        {
            AleynaKarakter.GetComponent<RectTransform>().DOScale(1, 0.3f);
        }
        else if (hangi == 5)
        {
            cankarakter.GetComponent<RectTransform>().DOScale(1, 0.3f);
        }
        else if (hangi == 6)
        {
            fatmaKarakter.GetComponent<RectTransform>().DOScale(1, 0.3f);
        }
        else if (hangi == 7)
        {
            korayKarakter.GetComponent<RectTransform>().DOScale(1, 0.3f);
        }
        else if (hangi == 8)
        {
            zeynepKarakter.GetComponent<RectTransform>().DOScale(1, 0.3f);
        }
    }

    public void karakterPanelKapa()
    {
        BabaKarakter.GetComponent<RectTransform>().DOScale(0, 0.3f);
        AnneKarakter.GetComponent<RectTransform>().DOScale(0, 0.3f);
        AhmetKarakter.GetComponent<RectTransform>().DOScale(0, 0.3f);
        AleynaKarakter.GetComponent<RectTransform>().DOScale(0, 0.3f);
        cankarakter.GetComponent<RectTransform>().DOScale(0, 0.3f);
        fatmaKarakter.GetComponent<RectTransform>().DOScale(0, 0.3f);
        korayKarakter.GetComponent<RectTransform>().DOScale(0, 0.3f);
        zeynepKarakter.GetComponent<RectTransform>().DOScale(0, 0.3f);
    }
    public void sosyalaktivilerPanelAcKapa(bool acik)
    {
        if (acik ==true)
        {
            sosyalAktivitiPanel.GetComponent<RectTransform>().DOScale(0, 0.3f);
        }
        else
        {
            sosyalAktivitiPanel.GetComponent<RectTransform>().DOScale(1, 0.3f);
        }
        
    }
   

}
