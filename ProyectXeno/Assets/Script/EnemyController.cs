using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

    public float enemySpeed;
    private Vector3 speed;
    //private GameObject enemigo;

    void Start()
    {

        speed = Vector3.back * enemySpeed;
        //enemigo = 
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed);

        Destroy(gameObject, 5f);
    }

    public void OnTriggerEnter(Collider ShipCol)
    {
        //Debug.Log(ShipCol);
        //Debug.Log(Upgrade_Shield);
        //Debug.Log(ShipCol.gameObject);

        if (ShipCol.transform.tag == "Ship" && YellowPowerup._shielded == false)
        {

            Destroy(ShipCol.gameObject);
        }
        else if (ShipCol.transform.tag == "Ship" && YellowPowerup._shielded == true)
        {
            Destroy(gameObject);
            YellowPowerup._shielded = false;
        }
    }




}
