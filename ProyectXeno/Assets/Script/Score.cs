﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Score : MonoBehaviour {

    public static Text score_text;
    public static uint score = 0;
    public static uint score_add = 1;
    public Text end_text;
    public Animator Canvas;


        // Use this for initialization
        void Start () {

        score_text = GetComponentInChildren<Text>();
        end_text.gameObject.SetActive(false);
        Canvas = GetComponent<Animator>();
        score = 0;

    }

    // Update is called once per frame
    void Update() {
        score_text.text = "" + score;

        if (Levels.dead_ship == true)
        {
            end_text.gameObject.SetActive(true);
            if (Input.GetKeyDown(KeyCode.Y))
            {
                end_text.gameObject.SetActive(false);
                SceneManager.LoadScene("MainScene");
                Levels.dead_ship = false;

            }
            else if (Input.GetKeyDown(KeyCode.N))
            {
                Application.Quit();
            }
        }


    }
}
