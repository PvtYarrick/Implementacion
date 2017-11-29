using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedPowerup : MonoBehaviour
{

    public static bool speeding = false;

    public float powerSpeed;
    private Vector3 speed;

    public static int NormalSpeed = 1;
    public static int ExtraSpeed = 2;


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
            Tube.tubeSpeed = ExtraSpeed;
            speeding = true;

        }
    }

    private void OnTriggerExit(Collider other)
    {


        if (other.transform.tag == "Ship")
        {
            Tube.tubeSpeed = NormalSpeed;
            speeding = false;

        }
    }
}
