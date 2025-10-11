using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ortadaki_kutu : MonoBehaviour
{
    float saglik = 100;
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
        healthBar.fillAmount = saglik / 100f;

        GameKontrol gk = gameKontrol.GetComponent<GameKontrol>();

        if (saglik <= 0)
        {
            // Patlama KUTUNUN olduðu yerde
            gk.Ses_ve_Efekt_Olustur(2, transform.position, transform.rotation);
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
