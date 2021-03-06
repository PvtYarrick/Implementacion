﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

    public float enemySpeed;
    private Vector3 speed;
    public uint score_enemy;
    protected int enemyLife;
    public static int shield_count = 3;

    protected virtual void Start()
    {

        //GetComponent<Rigidbody>().velocity = Vector3.back * enemySpeed / Time.deltaTime;
        //_enemykilledparticles = GetComponentInChildren<ParticleSystem>();
        //speed = Vector3.back * enemySpeed;
        Destroy(gameObject, 6f);
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        transform.Translate(Vector3.back * enemySpeed);
    }

    protected virtual void OnCollisionEnter(Collision ShipCol)
    {
        if (ShipCol.transform.tag == "Ship" && YellowPowerup._shielded == false && enemyLife > 0)
        {

            Destroy(ShipCol.gameObject);
            Levels.dead_ship = true;

        }
        else if (ShipCol.transform.tag == "Ship" && YellowPowerup._shielded == true)
        {
            enemyLife = 0;
            YellowPowerup._shielded = false;
            Score.score = Score.score + (score_enemy * Multiplier._Multiplier);
            PointsAdder.isEnemyDestroyed = true;
            PointsAdder.enemy_destroyed = this;
            Multiplier.MPCounter = Multiplier.MPCounter + (score_enemy / 10);
            Destroy(gameObject);
            Multiplier.killing_countdown = Multiplier.count;
        }
    }


    public int vida()
    {
        return enemyLife;
    }
    public uint enemyScore ()
    {
        return score_enemy;
    }
    public void hit(int dmg) {
        enemyLife -= dmg;
    }
}
