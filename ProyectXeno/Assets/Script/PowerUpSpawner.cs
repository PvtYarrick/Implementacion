using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpawner : MonoBehaviour {
    public List<GameObject> PowerUps;
    public Transform[] startPos;

    public float newPower = 400f;
    [SerializeField]
    private float lastPower = 0f;

    [SerializeField]
    int spawnPos;
    [SerializeField]
    int powerUpToSpawn;
    [SerializeField]
    int howLong;

    //public int debugSpawn;



    private void Start()
    {
        startPos = GetComponentsInChildren<Transform>();
    }

    private void Update()
    {
        if (lastPower >= newPower)
        {
            powerUpToSpawn = Random.Range(0, 3);
            howLong = Random.Range(1, 5);
            SpawnPower(powerUpToSpawn, howLong);
            lastPower = 0f;
        }
        else
        {
            lastPower = lastPower + Random.Range(1, 5);
        }

    }


    private void SpawnPower(int pwrUp, int lenght)
    {
        spawnPos = Random.Range(0, 7);
        //spawnPos = debugSpawn;

        for (int i = 0; i < lenght; i++)
        {
            if(i == 0) {
                Instantiate(PowerUps[pwrUp], startPos[spawnPos].position, startPos[spawnPos].rotation);
            }
            else if (i == 1)
            {
                Instantiate(PowerUps[pwrUp], startPos[spawnPos].position + new Vector3(0, 0, 32f), startPos[spawnPos].rotation);
            }
            else if (i == 2)
            {
                Instantiate(PowerUps[pwrUp], startPos[spawnPos].position + (new Vector3(0, 0, 32f) * 2), startPos[spawnPos].rotation);
            }
            else if (i == 3)
            {
                Instantiate(PowerUps[pwrUp], startPos[spawnPos].position + (new Vector3(0, 0, 32f) * 3), startPos[spawnPos].rotation);
            }
            else if (i == 4)
            {
                Instantiate(PowerUps[pwrUp], startPos[spawnPos].position + (new Vector3(0, 0, 32f) * 4), startPos[spawnPos].rotation);
            }


        }
    }

}
