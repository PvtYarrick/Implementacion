using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tube : MonoBehaviour {

    public float tubeSpeed;
    private Vector3 speed;

    void Start()
    {

         speed = Vector3.back * tubeSpeed;
    }

	// Update is called once per frame
	void Update () {
        

        transform.Translate(speed);
    }
}
