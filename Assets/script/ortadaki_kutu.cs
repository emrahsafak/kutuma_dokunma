using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ortadaki_kutu : MonoBehaviour
{
    float saglik= 100;
    public GameObject SaglikCanvasi;
    public Image healthBar;

    GameObject gameKontrol;

    private void Start()
    {
        gameKontrol = GameObject.FindWithTag("GameKontrol");
    }

    public void darbeal(float darbegucu)
    {

        saglik -= darbegucu;

        healthBar.fillAmount = saglik / 100;

        if (saglik <= 0)
        {
            gameKontrol.GetComponent<GameKontrol>().Ses_ve_Efekt_Olustur(2,gameObject);
            Destroy(gameObject);
        }

        else
        {
            StartCoroutine(CanvasCikar());
        }

           

    }

    IEnumerator CanvasCikar()
    {
        if (!SaglikCanvasi.activeInHierarchy)
        {
            SaglikCanvasi.SetActive(true);
            yield return new WaitForSeconds(2);
            SaglikCanvasi.SetActive(false);
        }
    }




}
