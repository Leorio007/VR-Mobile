using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DistanceCulling : MonoBehaviour
{
    public float maxDistance = 50f; 

    private Transform cameraTransform; 

    void Start()
    {
        cameraTransform = Camera.main.transform; 
    }

    void Update()
    {
        
        float distance = Vector3.Distance(transform.position, cameraTransform.position);

        
        if (distance > maxDistance)
        {
            gameObject.SetActive(false);
        }
        else 
        {
            gameObject.SetActive(true);
        }
    }
}


