using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

    public float enemySpeed;
    private Vector3 speed;
    protected uint score_enemy = 50;
    protected int enemyLife;
  

    protected virtual void Start()
    {

        speed = Vector3.back * enemySpeed;
        //_enemykilledparticles = GetComponentInChildren<ParticleSystem>();
        
        Destroy(gameObject, 6f);
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        transform.Translate(speed);
    }

    protected virtual void OnTriggerEnter(Collider ShipCol)
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
            Score.score = Score.score + score_enemy;
            Destroy(gameObject);
  
           
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
