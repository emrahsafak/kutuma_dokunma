using UnityEngine;

public class GameKontrol : MonoBehaviour
{
    [Header("TOP AYARLARI VE IÞLEMLERI")]
    public GameObject TopYokOlmaEfekt;
    public AudioSource TopPatlamaSesi;

    [Header("ORTADAKI KUTULARIN AYARLARI VE IÞLEMLERI")]
    public GameObject KutuYokOlmaEfekt;
    public AudioSource KutuPatlamaSesi;



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Ses_ve_Efekt_Olustur(int kriter,GameObject objetransformu)
    {

        switch (kriter)
        {
            case 1:
                Instantiate(TopYokOlmaEfekt, objetransformu.gameObject.transform.position, objetransformu.gameObject.transform.rotation);
                TopPatlamaSesi.Play();
                break;

            case 2:
                Instantiate(KutuYokOlmaEfekt, objetransformu.gameObject.transform.position, objetransformu.gameObject.transform.rotation);
                KutuPatlamaSesi.Play();
                break;



        }
        
    }




}
