using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levels : MonoBehaviour {

    private int placedTubes;

    //public List<int> order;
    //Indica el orden en el que se van a instanciar los planos que pongamos en niveles
    public List<GameObject> niveles;
    //public GameObject[] TubosEnJuego;
    //private GameObject _nivelactual;
    private int i;
    Vector3 PlaceForTheNextLevel;

    


    private static Levels _instance = null;


    void Awake() {

        //PlaceForTheNextLevel = transform.position + Vector3.forward * 10;

        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else if (_instance != this)
        {
            Destroy(gameObject);
        }
    }

    public static Levels getInstance() {
        return _instance;
    }


    //Cuando toca el trigger, TriggerCollider accede a esta función
    public void IveBeenTriggered() {
        //for (int i = 0; i < 6; i++) {
            
            Instantiate(niveles[Random.Range(0,4)], transform.position, Quaternion.identity);
        //print(Random.Range(1, 10));
            //PlaceForTheNextLevel += Vector3.forward * 40;
            /*GameObject segundoNivel = Instantiate(niveles[i + 1], transform.position, Quaternion.identity);
            PlaceForTheNextLevel += Vector3.forward * 40;*/
        //Destroy(_nivelactual);
        //_nivelactual = _siguientenivel;
        //i++;
            
           // Debug.Log ("Tubo creado");
       // }
       
    }



    // Use this for initialization
    void Start() {

  

    }
	
	// Update is called once per frame
	void Update() {
		
	}
}
