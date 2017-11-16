using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Score : MonoBehaviour {

    public static Text score_text;
    public static uint score;
    public static uint score_add = 1;
    public Image panel_1;
    public Image panel_2;
    public Text end_text;


        // Use this for initialization
        void Start () {

        score_text = GetComponentInChildren<Text>();
        end_text.gameObject.SetActive(false);
        score = 0;
    }
	
	// Update is called once per frame
	void Update () {
            score_text.text = "" + score;
        
            /*panel_1.enabled = SpeedPowerup.speeding;
            panel_2.enabled = SpeedPowerup.speeding; */

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
