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

            //�i de�i�tirdi ney�n yer�ne gedld�
            //GameObject topobjem =
        }
        
       
    }



}
