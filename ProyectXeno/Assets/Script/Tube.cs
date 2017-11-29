using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tube : MonoBehaviour {

    public static float tubeSpeed;
    private static Vector3 speed;

    public static float posToDestroy = -50;

    void Start()
    {

         speed = Vector3.back * tubeSpeed;
        tubeSpeed = SpeedPowerup.NormalSpeed;
    }
    void Update()
    {
        transform.Translate(speed);
    }

	// Update is called once per frame
	void LateUpdate () {
        


        if(transform.position.z < posToDestroy)
        {
            Levels.getInstance().IveBeenTriggered();
            Destroy(gameObject);
        }
    }
}
