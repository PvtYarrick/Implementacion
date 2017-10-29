using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour {

    public static Text score_text;
    public static int score = 0;
    public static int score_add = 1;

	// Use this for initialization
	void Start () {

        score_text = GetComponentInChildren<Text>();
    }
	
	// Update is called once per frame
	void Update () {

        score_text.text = "" + score;

    }
}
