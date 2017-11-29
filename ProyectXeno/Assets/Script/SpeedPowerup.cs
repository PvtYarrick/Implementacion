using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedPowerup : MonoBehaviour {

    public static bool speeding = false;
    public Animator Panels;

    public float powerSpeed;
    private Vector3 speed;


    private void Start()
    {
        Panels = GetComponent<Animator>();

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
            Tube.tubeSpeed = 2.5f;
            speeding = true;
            Panels.SetBool("speeding", true);
        }
    }

    private void OnTriggerExit(Collider other)
    {


        if (other.transform.tag == "Ship"){ 
            Tube.tubeSpeed = 1.5f;
            speeding = false;
            Panels.SetBool("speeding", false);
        }
    }
}
