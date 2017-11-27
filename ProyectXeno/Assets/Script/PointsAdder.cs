using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;   

public class PointsAdder : MonoBehaviour {

    public Text ScoreMultiplier_text;
    public Animator ScoreMultiplier_anim;
    public static bool isEnemyDestroyed;
    public static EnemyController enemy_destroyed;

    // Use this for initialization
    void Start()
    {
        ScoreMultiplier_anim = GetComponent<Animator>();
        ScoreMultiplier_text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {

        if (isEnemyDestroyed == true)
        {
            ScoreMultiplier_anim.SetTrigger("Enemy_dies");
            ScoreMultiplier_text.text = "+" + enemy_destroyed.score_enemy;
            isEnemyDestroyed = false;
            
        }
        if (SpeedPowerup.speeding == true)
        {
            ScoreMultiplier_anim.SetTrigger("Enemy_dies");
            ScoreMultiplier_text.text = "x2";

        }
    }
}
