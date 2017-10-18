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

    private void OnTriggerEnter(Collider col)
    {
        if(col.transform.tag == "Ship")
        {
            Destroy(col.gameObject);
        }else if (col.transform.tag == "Shielded")
        {
            Destroy(gameObject);
        }


    
            
    }


}
