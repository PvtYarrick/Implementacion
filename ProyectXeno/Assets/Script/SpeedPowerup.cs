using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedPowerup : MonoBehaviour {

    public static bool speeding = false;
    public Animator Panels;

    void Start()
    {
        Panels = GetComponent<Animator>();
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
