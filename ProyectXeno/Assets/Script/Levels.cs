using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levels : MonoBehaviour {

    //public List<int> order;
    //Indica el orden en el que se van a instanciar los planos que pongamos en niveles
    public List<GameObject> niveles;
    //Indica que planos van a instanciarse
    private GameObject _nivelactual;
    private int i;
    Vector3 PlaceForTheNextLevel;

    private static Levels _instance = null;


    void Awake() {

        PlaceForTheNextLevel = transform.position + Vector3.forward * 10;

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

        GameObject _siguientenivel = Instantiate(niveles[i], PlaceForTheNextLevel, Quaternion.identity);
        Destroy(_nivelactual);
        _nivelactual = _siguientenivel;
        i++;
        PlaceForTheNextLevel += Vector3.forward * 40;
    }



    // Use this for initialization
    void Start() {
		
	}
	
	// Update is called once per frame
	void Update() {
		
	}
}
