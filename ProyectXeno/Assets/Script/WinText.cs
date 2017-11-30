using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WinText : MonoBehaviour {

    public Text winText;

    // Use this for initialization
    void Start () {

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
