using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldController : MonoBehaviour {

    public float worldSpeed;

   


    private Vector3 speed;
    

    void Start()
    {
        
       

    }

    // Update is called once per frame
    void Update()
    {

        speed = Vector3.back * worldSpeed;


        transform.Translate(speed);

       
    }
}
