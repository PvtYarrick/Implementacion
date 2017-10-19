using System.Collections;
using UnityEngine;
//using UnityEditor;


//[ExecuteInEditMode]
public class EnemySpawner : MonoBehaviour
{

    public GameObject basicEnemy;
    public Transform[] startPos;



    public float newEnemy = 300f;
    [SerializeField]
    private float lastEnemy = 0f;

   

    private void Start()
    {
        startPos = GetComponentsInChildren<Transform>();
    }

    private void Update()
    {

        //SpawnEnemy();
        if(lastEnemy >= newEnemy)
        {
            SpawnEnemy();
            lastEnemy = 0f;
        }else
        {
            lastEnemy = lastEnemy + Random.Range(1,5);
        }

        /*if (Input.GetKey("e"))
        {
            SpawnEnemy();
        }*/
            

    }


    private void SpawnEnemy()
    {
        Instantiate(basicEnemy, startPos[Random.Range(0,6)].position, Quaternion.identity);
    }










}
