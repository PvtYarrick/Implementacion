using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndPoint : MonoBehaviour
{

    public float endSpeed = 1;
    public string winScene;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Movement.winCondition)
        {
            transform.Translate(Vector3.back * endSpeed);
        }

    }
    void OnTriggerEnter(Collider ShipCol)
    {
        if (ShipCol.transform.tag == "Ship")
        {
            SceneManager.LoadScene(winScene);
            Destroy(ShipCol.gameObject);

        }
    }
}