using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

    public float enemySpeed;
    private Vector3 speed;
    //private GameObject enemigo;
    //private ParticleSystem _enemykilledparticles;

    void Start()
    {

        speed = Vector3.back * enemySpeed;
        //_enemykilledparticles = GetComponentInChildren<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed);

        Destroy(gameObject, 5f);
    }

    public void OnTriggerEnter(Collider ShipCol)
    {
        Debug.Log("Destroyed");

        if (ShipCol.transform.tag == "Ship" && YellowPowerup._shielded == false)
        {

            Destroy(ShipCol.gameObject);
            Levels.dead_ship = true;

        }
        else if (ShipCol.transform.tag == "Ship" && YellowPowerup._shielded == true)
        {
            //_enemykilledparticles.Play();
            Destroy(gameObject);
            YellowPowerup._shielded = false;
        }
    }




}
