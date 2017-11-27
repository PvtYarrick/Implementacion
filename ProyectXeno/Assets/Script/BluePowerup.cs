using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BluePowerup : MonoBehaviour {

    public float powerSpeed;
    private Vector3 speed;


     private void Start()
    {

        speed = Vector3.back * powerSpeed;
        
        //_enemykilledparticles = GetComponentInChildren<ParticleSystem>();

        Destroy(gameObject, 18f);
    }

    // Update is called once per frame
    private void Update()
    {
        transform.Translate(speed);
    }


    private void OnTriggerEnter(Collider other)
    {
        

        if (other.transform.tag == "Ship")
        {
            //Debug.Log("Im in");
            Movement.isBlueActive = true;
            
        }
    }

    private void OnTriggerExit(Collider other)
    {

        
        if (other.transform.tag == "Ship")
        {
            //Debug.Log("Im out");
            Movement.isBlueActive = false;
           
        }
    }
}
