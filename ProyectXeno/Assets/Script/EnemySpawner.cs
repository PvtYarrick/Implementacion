using System.Collections;
using UnityEngine;
using System.Collections.Generic;


public class EnemySpawner : MonoBehaviour
{

    public List<GameObject> Enemies;
    public Transform[] startPos;
    public int debugSpawnPos;
    private int spawnPos;

    public static AudioSource damageTaken;

    public float newEnemy = 80f;
    [SerializeField]
    private float lastEnemy = 0f;




    private void Start()
    {
        startPos = GetComponentsInChildren<Transform>();
        damageTaken = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (lastEnemy >= newEnemy)
        {
            SpawnEnemy();
            lastEnemy = 0f;
        }
        else
        {
            lastEnemy = lastEnemy + Random.Range(1, 5);
        }
        if (Movement.winCondition == true)
        {
            Destroy(gameObject);
        }

    }


    private void SpawnEnemy()
    {
        //spawnPos = Random.Range(0, 7);
        //Instantiate(Enemies[Random.Range(0,3)], startPos[spawnPos].position, startPos[spawnPos].rotation);

        //Debug rotation code;
        Instantiate(Enemies[1], startPos[debugSpawnPos].position, startPos[debugSpawnPos].rotation);
    }
    
}
