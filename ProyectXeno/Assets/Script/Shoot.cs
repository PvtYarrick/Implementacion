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
        Destroy(gameObject, 0.5f);

    }

    void OnTriggerEnter(Collider col)
    {
        if (col.transform.tag == "Enemy")
        {
            EnemyController obj = col.gameObject.GetComponent<EnemyController>();
            obj.hit(1);

            if (obj.vida() <= 0)
            {
                Destroy(col.gameObject);
                Score.score = Score.score + obj.enemyScore();
                Multiplier.isEnemyDestroyed = true;
                Multiplier.enemy_destroyed = obj;
                ActualMultiplier.MPCounter = ActualMultiplier.MPCounter + (EnemyController.score_enemy / 10);
            }
        }
}
}
