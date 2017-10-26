using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowPowerup : MonoBehaviour {

    public static bool _shielded;
	
    void OnTriggerEnter(Collider col)
    {
        if (col.transform.tag == "Ship")
        {
            _shielded = true;
        }
    }
}
