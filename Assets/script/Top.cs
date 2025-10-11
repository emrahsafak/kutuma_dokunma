using UnityEngine;

public class Top : MonoBehaviour
{
    float darbegucu;

    GameObject gameKontrol;
    GameObject Oyuncu;

    void Start()
    {
        darbegucu = 20;
        gameKontrol = GameObject.FindWithTag("GameKontrol");
        Oyuncu = GameObject.FindWithTag("Oyuncu_1");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameKontrol gk = gameKontrol.GetComponent<GameKontrol>();

        if (collision.gameObject.CompareTag("Ortadaki_kutular"))
        {
            collision.gameObject.GetComponent<ortadaki_kutu>().darbeal(darbegucu);

            // Patlama TOPUN olduðu yerde
            gk.Ses_ve_Efekt_Olustur(1, transform.position, transform.rotation);
            Oyuncu.GetComponent<Oyuncu>().PowerOynasin();
            Destroy(gameObject);
        }

        if (collision.gameObject.CompareTag("Oyuncu_2Kule") || collision.gameObject.CompareTag("Oyuncu_2"))
        {
            // Patlama TOPUN olduðu yerde
            gk.Ses_ve_Efekt_Olustur(1, transform.position, transform.rotation);
            gk.Darbe_vur(2, darbegucu);
            Oyuncu.GetComponent<Oyuncu>().PowerOynasin();
            Destroy(gameObject);
        }

        if (collision.gameObject.CompareTag("Oyuncu_1_Kule")|| collision.gameObject.CompareTag("Oyuncu_1"))
        {
            // Patlama TOPUN olduðu yerde
            gk.Ses_ve_Efekt_Olustur(1, transform.position, transform.rotation);
            gk.Darbe_vur(1, darbegucu);
            Oyuncu.GetComponent<Oyuncu>().PowerOynasin();
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("Zemin"))
        {
            // Patlama TOPUN olduðu yerde
            gk.Ses_ve_Efekt_Olustur(1, transform.position, transform.rotation);
            Oyuncu.GetComponent<Oyuncu>().PowerOynasin();
            Destroy(gameObject);
        }
    }

    void Update()
    {

    }
}
