using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedPowerup : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {


        if (other.transform.tag == "Ship")
        {
            //Debug.Log("SPEEEEEEEEEEEEEED");
            Tube.tubeSpeed = 1.5f;
        }
    }

    private void OnTriggerExit(Collider other)
    {


        if (other.transform.tag == "Ship")
        {
            //Debug.Log("You cant run from the past");
            Tube.tubeSpeed = 0.8f;
        }
    }
}
