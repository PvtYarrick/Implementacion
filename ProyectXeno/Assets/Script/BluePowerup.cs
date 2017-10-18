using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BluePowerup : MonoBehaviour {

    

    /*private void Start()
    {
        playerRef = GetComponent<Movement>();
    }*/

    private void Update()
    {
        if (Input.GetKey("e"))
        {
            Debug.Log("e pressed");
            Movement.isBlueActive = !Movement.isBlueActive;
        }
           
    }

    private void OnTriggerEnter(Collider other)
    {
        

        if (other.transform.tag == "Ship")
        {
            Debug.Log("Im in");
            Movement.isBlueActive = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {

        
        if (other.transform.tag == "Ship")
        {
            Debug.Log("Im out");
            Movement.isBlueActive = false;
        }
    }
}
