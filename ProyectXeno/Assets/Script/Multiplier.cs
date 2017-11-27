using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Multiplier : MonoBehaviour {

    public static Text ScoreMultiplier_text;
    public Animator ScoreMultiplier_anim;
    public static uint _Multiplier;
    public static uint MPCounter;

    // Use this for initialization
    void Start()
    {
        ScoreMultiplier_anim = GetComponent<Animator>();
        ScoreMultiplier_text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (MPCounter >= 10)
        {
            ScoreMultiplier_anim.SetTrigger("MultiplierBump");
            _Multiplier = _Multiplier + 1;
            ScoreMultiplier_text.text = "x" + _Multiplier;
            MPCounter = 0;

        }
    }
}
