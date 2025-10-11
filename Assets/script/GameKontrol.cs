using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class GameKontrol : MonoBehaviour
{
    [Header("TOP AYARLARI VE IÞLEMLERI")]
    public GameObject TopYokOlmaEfekt;
    public AudioSource TopPatlamaSesi;

    [Header("ORTADAKI KUTULARIN AYARLARI VE IÞLEMLERI")]
    public GameObject KutuYokOlmaEfekt;
    public AudioSource KutuPatlamaSesi;

    [Header("OYUNCU SAGLIK AYARLARI VE IÞLEMLERI")]
    public Image Oyuncu_1_saglik_Bar;
    float Oyuncu_1_saglik = 100;
    public Image Oyuncu_2_saglik_Bar;
    float Oyuncu_2_saglik = 100;

    void Start()
    {

    }

    void Update()
    {

    }

    // --- BURASI YENÝ VERSIYON ---
    public void Ses_ve_Efekt_Olustur(int kriter, Vector3 pos, Quaternion rot)
    {
        switch (kriter)
        {
            case 1:
                Instantiate(TopYokOlmaEfekt, pos, rot);
                TopPatlamaSesi.Play();
                break;

            case 2:
                Instantiate(KutuYokOlmaEfekt, pos, rot);
                KutuPatlamaSesi.Play();
                break;
        }
    }
    // -------------------------------

    public void Darbe_vur(int kriter, float darbegucu)
    {
        switch (kriter)
        {
            case 1:
                Oyuncu_1_saglik -= darbegucu;
                Oyuncu_1_saglik_Bar.fillAmount = Oyuncu_1_saglik / 100f;

                if (Oyuncu_1_saglik <= 0)
                {
                    Debug.Log("Oyuncu 1 Öldü");
                }
                break;

            case 2:
                Oyuncu_2_saglik -= darbegucu;
                Oyuncu_2_saglik_Bar.fillAmount = Oyuncu_2_saglik / 100f;

                if (Oyuncu_2_saglik <= 0)
                {
                    Debug.Log("Oyuncu 2 Öldü");
                }
                break;
        }
    }
}
