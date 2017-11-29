using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowPowerup : MonoBehaviour {

    public static bool _shielded;

    public float powerSpeed;
    private Vector3 speed;


    private void Start()
    {

        speed = Vector3.back * powerSpeed;

        //_enemykilledparticles = GetComponentInChildren<ParticleSystem>();

        Destroy(gameObject, 18f);
    }

    // Update is called once per frame
    private void Update()
    {
        transform.Translate(speed);
    }

    void OnTriggerEnter(Collider col)
    {

        if (col.transform.tag == "Ship")
        {
            _shielded = true;
            
        }
    }
}
