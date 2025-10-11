using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class Oyuncu : MonoBehaviour
{

    public GameObject top;
    public GameObject TopCikisNoktasi;
    public ParticleSystem TopAtýsEfekt;
    public AudioSource TopAtmaSesi;

    void Start()
    {
        
    }



    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            Instantiate(TopAtýsEfekt, TopCikisNoktasi.transform.position, TopCikisNoktasi.transform.rotation);
            TopAtmaSesi.Play(); 
            GameObject topobjem = Instantiate(top, TopCikisNoktasi.transform.position, TopCikisNoktasi.transform.rotation);
            Rigidbody2D rg = topobjem.GetComponent<Rigidbody2D>();
            rg.AddForce(new Vector2 (2f,0f) * 10f, ForceMode2D.Impulse);
            TopAtýsEfekt.Play();

        }


    }



}
