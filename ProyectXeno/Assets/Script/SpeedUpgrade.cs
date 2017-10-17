using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUpgrade : MonoBehaviour {

    public Tube tubeScript;
    private GameObject col;

	// Use this for initialization
	void Start () {

        
	}

    void OnTriggerStay (Collider col) {

        if (col.transform.tag == "Ship")
        {
            //Debug.Log("Entering");
            tubeScript.tubeSpeed = 27;
        }
        else
        {
            //Debug.Log("Entering");
            tubeScript.tubeSpeed = 0.8F;
        }
    }
    
	
	// Update is called once per frame
	void Update () {
		
	}
}
