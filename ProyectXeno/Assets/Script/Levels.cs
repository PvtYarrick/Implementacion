using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levels : MonoBehaviour {

    
    public static Transform currentPos;

    private int placedTubes;

    //public List<int> order;
    //Indica el orden en el que se van a instanciar los planos que pongamos en niveles
    public List<GameObject> niveles;
    //public GameObject[] TubosEnJuego;
    //private GameObject _nivelactual;
    private int i;
    Vector3 PlaceForTheNextLevel;

    


    private static Levels _instance = null;


    private void Start()
    {
        currentPos = GetComponent<Transform>();
        currentPos.position = new Vector3(0,0,48.5f);
    }


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
        IveBeenTriggered();
        IveBeenTriggered();
        IveBeenTriggered();
        IveBeenTriggered();
        IveBeenTriggered();
    }

    private void Update()
    {
        if (Tube.tubeSpeed == 0.8f)
        {
            currentPos.position = new Vector3(0, 0, 48.5f);
        }else if (Tube.tubeSpeed == 1.5f)
        {
            currentPos.position = new Vector3(0, 0, 52.4f);
        }
    }

    public static Levels getInstance() {
        return _instance;
    }

    GameObject lastInstantiated;
    [SerializeField]
    float length = 18;

    //Cuando toca el trigger, TriggerCollider accede a esta función
    public void IveBeenTriggered() {
        //for (int i = 0; i < 6; i++) {
        //Debug.Log("Spawn!");
        Vector3 pos = transform.position;
        if (lastInstantiated != null)
            pos = lastInstantiated.transform.position +  Vector3.forward * length;
        lastInstantiated = Instantiate(niveles[Random.Range(0,5)], pos, Quaternion.identity);
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



   
}
