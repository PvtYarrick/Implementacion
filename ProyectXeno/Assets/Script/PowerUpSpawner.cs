using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpawner : MonoBehaviour {
    public List<GameObject> PowerUps;
    public Transform[] startPos;

    public float newPower = 400f;
    [SerializeField]
    private float lastPower = 0f;



    private void Start()
    {
        startPos = GetComponentsInChildren<Transform>();
    }

    private void Update()
    {
        if (lastPower >= newPower)
        {
            SpawnPower();
            lastPower = 0f;
        }
        else
        {
            lastPower = lastPower + Random.Range(1, 5);
        }

    }


    private void SpawnPower()
    {
        Instantiate(PowerUps[Random.Range(0, 2)], startPos[Random.Range(0, 6)].position, Quaternion.identity);
    }

}
