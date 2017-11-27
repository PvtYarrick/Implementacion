using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTwo : EnemyController {

    void Awake()
    {
        enemySpeed = 1f;
        score_enemy = 30;
        enemyLife = 2;
        
}

    // Use this for initialization
    protected override void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    protected override void Update()
    {
        base.Update();
    }

    protected override void OnTriggerEnter(Collider ShipCol)
    {
        base.OnTriggerEnter(ShipCol);
    }
}
