using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedParticles : MonoBehaviour {

    private ParticleSystem _speedparticles;


	// Use this for initialization
	void Start () {

        _speedparticles = GetComponentInChildren<ParticleSystem>();
	}
	
	// Update is called once per frame
	void Update () {
		
        if (SpeedPowerup.speeding == true)
        {
            _speedparticles.Play();

        }
        else
        {

            _speedparticles.Stop();
        }
	}
}
