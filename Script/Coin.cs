using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int CoinCollected = 0;

    public TMP_Text CoinText;
    public TMP_Text winText;


    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Coin"))
        {
            CoinCollected++;
            CoinText.text = "Collecting coin :" + CoinCollected + "/2";
            Destroy(collider.gameObject);
        }

        if (CoinCollected >= 2)
        {
            winText.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
