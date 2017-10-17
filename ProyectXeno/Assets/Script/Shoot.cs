using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

    public float shootSpeed;
    private Vector3 shootspeed;

    // Use this for initialization
    void Start () {

        shootspeed = Vector3.forward * shootSpeed;
       
    }
	
	// Update is called once per frame
	void Update () {

        transform.Translate(shootspeed);
        Destroy(gameObject, 5f);

    }
}
