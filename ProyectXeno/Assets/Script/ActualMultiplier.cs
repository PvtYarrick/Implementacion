using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActualMultiplier : MonoBehaviour {

    public static Text ActualScoreMultiplier_text;
    public Animator ActualScoreMultiplier_anim;
    public static uint _Multiplier;
    public static uint MPCounter;

    // Use this for initialization
    void Start () {
        ActualScoreMultiplier_anim = GetComponent<Animator>();
        ActualScoreMultiplier_text = GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {
        Debug.Log(MPCounter);
        if (MPCounter >= 10)
        {
            ActualScoreMultiplier_anim.SetTrigger("MultiplierBump");
            _Multiplier = _Multiplier + 1;
            ActualScoreMultiplier_text.text = "x" + _Multiplier;
            MPCounter = 0;

        }
    }
}
