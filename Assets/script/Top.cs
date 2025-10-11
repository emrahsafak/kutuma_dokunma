using UnityEngine;

public class Top : MonoBehaviour
{
    float darbegucu;
    

    GameObject gameKontrol;


    void Start()
    {
        darbegucu = 20;

        gameKontrol = GameObject.FindWithTag("GameKontrol");
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Ortadaki_kutular"))
        {
            collision.gameObject.GetComponent<ortadaki_kutu>().darbeal(darbegucu);

            gameKontrol.GetComponent<GameKontrol>().Ses_ve_Efekt_Olustur(1,collision.gameObject);

           
            Destroy(gameObject);    

            //GetComponent<CircleCollider2D>().isTrigger = false;

        }
        
    }
    void Update()
    {
        
    }
}
