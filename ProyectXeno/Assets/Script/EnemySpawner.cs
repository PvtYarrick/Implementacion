using System.Collections;
using UnityEngine;
using System.Collections.Generic;


public class EnemySpawner : MonoBehaviour
{

    public List<GameObject> Enemies;
    public Transform[] startPos;
    private int spawnPos;



    public float newEnemy = 80f;
    [SerializeField]
    private float lastEnemy = 0f;

   

    private void Start()
    {
        startPos = GetComponentsInChildren<Transform>();
    }

    private void Update()
    {
        if(lastEnemy >= newEnemy)
        {
            SpawnEnemy();
            lastEnemy = 0f;
        }else
        {
            lastEnemy = lastEnemy + Random.Range(1,5);
        }

    }


    private void SpawnEnemy()
    {
        spawnPos = Random.Range(0, 7);
        Instantiate(Enemies[Random.Range(0,2)], startPos[spawnPos].position, startPos[spawnPos].rotation);

        //Debug rotation code
        //Instantiate(Enemies[0], startPos[0].position, startPos[0].rotation);
    }
}
