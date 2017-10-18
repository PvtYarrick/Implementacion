using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgrade_Shield : MonoBehaviour {

    public static bool _shielded = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter (Collider col)
    {
        if (col.transform.tag == "Ship")
        {
            _shielded = true;
            Debug.Log("Me pongo a true");
        }
    }
}
