using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeShipMaterial : MonoBehaviour {

    Renderer rend;

    public Material mat_ship;
    public Material mat_shielded;



    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (YellowPowerup._shielded == true)
        {
            //Debug.Log ("I'm yellow and shielded");
            rend.material = mat_shielded;
        }
        else
        {
            rend.material = mat_ship;
        }

    }
}
