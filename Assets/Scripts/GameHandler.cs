using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameHandler : MonoBehaviour
{
   // public Text CoinText;
    public int coin = 0;

    public TextMeshProUGUI CoinText;

    //test
    public int score = 0;
    public GameObject textObject;








    void Start()
    {


       // score += 1;
       
       
       // bool hasCollectedCoin = false;

        //  CoinText.GetComponent<Text>().text = "Coin Text : ";
    }


                  




    // Update is called once per frame
    void Update()
    {
        

        // test
        if (coin == 3)
        {
            textObject.SetActive(true);
        }




        CoinText.text = "Coins : " + coin;
    }
}
