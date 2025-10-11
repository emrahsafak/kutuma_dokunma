using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class Oyuncu : MonoBehaviour
{
    [Header("Top Ayarlarý")]
    public GameObject top;
    public GameObject TopCikisNoktasi;
    public ParticleSystem TopAtýsEfekt;
    public AudioSource TopAtmaSesi;

    [Header("Power Bar Ayarlarý")]
    public Image PowerBar;
    public float powerSpeed = 0.5f; // Saniyede ne kadar dolsun, boþalsýn ( 0-1 ) arasý 
    bool sonageldimi=false; // Bar sonuna geldi mi gelmedi mi ?
    Coroutine powerDongu;


    void Start()
    {
       /* PowerBar.fillAmount = 0f;
        sonageldimi = false;*/
        powerDongu = StartCoroutine(PowerBarCalistir()); // Run power bar all the time 

    }

    IEnumerator PowerBarCalistir()
    {
       
        while (true)
        {
            

            if ( !sonageldimi)
            {
                PowerBar.fillAmount += powerSpeed * Time.deltaTime; // Bar soldan saða doðru doluyor. 

                if(PowerBar.fillAmount >= 1f)
                {
                    PowerBar.fillAmount = 1f;
                    sonageldimi = true;
                }
            }

            else
            {
                PowerBar.fillAmount -= powerSpeed * Time.deltaTime; // Bar saðdan sola doðru doluyor.

                if( PowerBar.fillAmount <= 0f)
                {
                    PowerBar.fillAmount = 0f;
                    sonageldimi = false;
                }
            }

            yield return null; // Her frame bir kere çalýþ

        }


    }



    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Efekt + ses
            Instantiate(TopAtýsEfekt, TopCikisNoktasi.transform.position, TopCikisNoktasi.transform.rotation);
            TopAtmaSesi.Play();

            // Topu üret ve kuvvet uygula
            GameObject topobjem = Instantiate(top, TopCikisNoktasi.transform.position, TopCikisNoktasi.transform.rotation);
            Rigidbody2D rg = topobjem.GetComponent<Rigidbody2D>();

            // PowerBar.fillAmount (0–1) ile çarpýyoruz
            rg.AddForce(new Vector2(2f, 0f) * PowerBar.fillAmount * 12f, ForceMode2D.Impulse);

            // Power bar’ý durdur (çarpma olunca yeniden baþlatacaðýz)
            if (powerDongu != null)
                StopCoroutine(powerDongu);
        }

       

    }

    public void PowerOynasin()
    {
        // Eski coroutine varsa durdur, sonra sýfýrdan baþlat
        if (powerDongu != null)
            StopCoroutine(powerDongu);

        powerDongu = StartCoroutine(PowerBarCalistir());
    }
}


