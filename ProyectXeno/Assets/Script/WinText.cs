using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WinText : MonoBehaviour {

    public Text winText;
    private Animator anim_text;

    // Use this for initialization
    void Start () {

        anim_text = GetComponentInChildren<Animator>();
        anim_text.SetTrigger("Start");
    }
	
	// Update is called once per frame
	void Update () {

        

        if (Input.GetKeyDown(KeyCode.Y))
        {
            winText.gameObject.SetActive(false);
            SceneManager.LoadScene("MainScene");
            Levels.dead_ship = false;

        }
        else if (Input.GetKeyDown(KeyCode.N))
        {
            Application.Quit();
        }
    }
}
