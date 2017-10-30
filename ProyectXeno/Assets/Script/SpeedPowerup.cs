using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedPowerup : MonoBehaviour {

    public static bool speeding = false;


    private void OnTriggerEnter(Collider other)
    {


        if (other.transform.tag == "Ship")
        {
            //Debug.Log("SPEEEEEEEEEEEEEED");
            Tube.tubeSpeed = 2.5f;
            speeding = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {


        if (other.transform.tag == "Ship")
        {
            //Debug.Log("You cant run from the past");
            Tube.tubeSpeed = 1.5f;
            speeding = false;
        }
    }
}
