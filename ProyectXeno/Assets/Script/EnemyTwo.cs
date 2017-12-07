using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTwo : EnemyController {

    public Animator damageFlash;

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

        damageFlash = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    protected override void Update()
    {
        base.Update();
    }

    protected override void OnCollisionEnter(Collision ShipCol)
    {
        base.OnCollisionEnter(ShipCol);
    }

    public void DamageFlash()
    {
        damageFlash.SetTrigger("RecivedDamage");
    }
}
