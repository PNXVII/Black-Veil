using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int KittyCollected = 0;
    public int CoinCount = 0;
    public AudioSource playerSource;
    public AudioClip catSound;
    public AudioClip coinSound;

    public TMP_Text Kitty;
    public TMP_Text CoinText;
    public TMP_Text winText;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Kitty"))
        {
            playerSource.PlayOneShot(catSound);
            KittyCollected++;
            Kitty.text = "Find Kitty"; //+CoinCollected + "/2"
            Destroy(collider.gameObject);
        }

        if (KittyCollected >= 1)
        {
            winText.gameObject.SetActive(true);
            Time.timeScale = 0;
        }

        if (collider.gameObject.CompareTag("Coin"))
        {
            playerSource.PlayOneShot(coinSound);
            CoinCount++;
            CoinText.text = "Chip :" + CoinCount ;
            Destroy(collider.gameObject);
        }
    }
}
