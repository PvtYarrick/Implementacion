using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCollider : MonoBehaviour
{

    private GameObject col;

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


    }
    void OnTriggerEnter(Collider col)
    { if (col.transform.tag == "Ship" || col.transform.tag == "Shielded")
        {

            Levels.getInstance().IveBeenTriggered();
        }
    }
}
