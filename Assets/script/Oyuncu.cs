using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class Oyuncu : MonoBehaviour
{

    public GameObject top;
    public GameObject TopCikisNoktasi;

    void Start()
    {
        
    }



    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
           Instantiate(top, TopCikisNoktasi.transform.position, TopCikisNoktasi.transform.rotation);

            //ýi deðiþtirdi neyýn yerýne gedldý
            //GameObject topobjem =
        }
        
       
    }



}
