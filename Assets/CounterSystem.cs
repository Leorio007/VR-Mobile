using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CounterSystem : MonoBehaviour
{

    

    

    public int score = 0;




    

   

    public Text scoreText; 

    void Start()
    {
        scoreText.text = score.ToString() + "POINTS";
    }


    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Projectile"))
        {
            score += 10;
            scoreText.text = "Score: " + score.ToString();
        }
    }


  

    
    void Update()
    {
        
    }
}
