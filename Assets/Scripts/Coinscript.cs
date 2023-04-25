using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coinscript : MonoBehaviour
{
    //private bool _checkRaycast;
    public GameHandler GameHandler;

    void Start()
    {
        GameHandler = GameObject.Find("Canvas").GetComponent<GameHandler>();

        
    }





    // Update is called once per frame
    void Update()
    {
       // if _checkRaycast
      
    }


    private void OnTriggerEnter(Collider other)
    {
        // if (other.name == "FirstPersonPlayer")

        //   other.GetComponent<PlayerCoin>().points++;



        GameHandler.coin++;
        //Add1 to points.
        Destroy(gameObject);
    }
}
