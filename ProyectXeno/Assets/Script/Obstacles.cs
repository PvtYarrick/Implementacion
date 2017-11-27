using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : EnemyController {

    void Awake()
    {
        enemySpeed = 1f;
        score_enemy = 200;
        enemyLife = 500;
    }

    // Use this for initialization
    protected override void Start () {
        base.Start();
	}
	
	// Update is called once per frame
	protected override void Update () {
        base.Update();
	}
    protected override void OnCollisionEnter(Collision ShipCol)
    {
        base.OnCollisionEnter(ShipCol);
    }
}
