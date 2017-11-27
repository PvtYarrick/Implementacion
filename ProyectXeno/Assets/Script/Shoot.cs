using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

    public float shootSpeed;
    private Vector3 shootspeed;

    // Use this for initialization
    void Start () {
        GetComponent<Rigidbody>().velocity = Vector3.forward * shootSpeed / Time.deltaTime;
        Destroy(gameObject, 0.5f);
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.transform.tag == "Enemy")
        {
            EnemyController obj = col.gameObject.GetComponent<EnemyController>();
            obj.hit(1);
            if (obj.vida() <= 0)
            {
                Destroy(col.gameObject);
                Score.score = Score.score + obj.enemyScore();
                PointsAdder.isEnemyDestroyed = true;
                PointsAdder.enemy_destroyed = obj;
            }
            Destroy(gameObject);
        }
}
}
