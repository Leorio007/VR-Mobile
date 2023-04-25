using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class WinState : MonoBehaviour
{

    public int coinCount = 0;

    public TextMeshProUGUI textObject;


    void Update()
    {
        if (coinCount == 3)
        {
            textObject.enabled = true;

            coinCount++;

        }
    }


    //  public TextMeshProUGUI winText;
    // public int totalCoins;
    // private int coinsCollected;

    void Start()
    {
       // coinsCollected = 0;
       // winText.enabled = false;
    }

    void OnTriggerEnter(Collider other)
    {
       // if (other.gameObject.CompareTag("Coin"))
        {
            //coinsCollected++;
           // Destroy(other.gameObject);
           // if (coinsCollected >= totalCoins)
            {
               // winText.enabled = true;
            }
        }
    }
}

