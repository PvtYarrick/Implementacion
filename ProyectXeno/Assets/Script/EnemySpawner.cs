using System.Collections;
using UnityEngine;
using System.Collections.Generic;


public class EnemySpawner : MonoBehaviour
{

    public List<GameObject> Enemies;
    //public List<GameObject> enemies;
    public Transform[] startPos;



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
        Instantiate(Enemies[Random.Range(0, 2)], startPos[Random.Range(0, 6)].position, Quaternion.identity);
    }
}
