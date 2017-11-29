using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Score : MonoBehaviour
{

    public static Text score_text;
    public static uint score;
    public static uint score_add = 1;
    public Text end_text;
    public Text winText;
    public GameObject BluePowerUp;



    // Use this for initialization
    void Start()
    {

        score_text = GetComponentInChildren<Text>();
        end_text.gameObject.SetActive(false);
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
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

        if (score >= 10000F)
        {
            Movement.winCondition = true;
            winText.gameObject.SetActive(true);
            if (Input.GetKeyDown(KeyCode.Y))
            {
                winText.gameObject.SetActive(false);
                SceneManager.LoadScene("MainScene");
            }
            else if (Input.GetKeyDown(KeyCode.N))
            {
                Application.Quit();
            }
            if (Movement.winCondition == true)
            {
                score_text.text = "" + score;
            }
        }

    }
}
