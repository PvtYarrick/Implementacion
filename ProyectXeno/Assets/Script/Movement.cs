using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Movement : MonoBehaviour
{
    public Railes rail;

    //Shooting stuff
    public GameObject Shoot;
    public Transform ShootSpawn;
    public Transform ShootSpawnRight;
    public Transform ShootSpawnLeft;
    private float fireDelta = 0.5F;
    private float nextFire = 1F;
    private float myTime = 0.0F;


    public PlayMode mode;


    public static bool isBlueActive = false;

    public float moveSpeed = 10f;
    private float speed = 5f;
    public bool isReversed;
    public bool isLooped = true;
    public bool PingPong = true;

    [SerializeField]
    private int currentSeg;
    private float transition;
    private bool isCompleted;
    [SerializeField]
    private int whereAmI = 0;

    public Renderer rend;

    public Material mat_ship;
    public Material mat_shielded;

    public static bool winCondition;

    private AudioSource pew;
    public AudioSource threepew;

    //private float endSpeed = -3;
    //public Rigidbody rb;


    private void Start()
    {
        rend = GetComponentInChildren<Renderer>();
        rend.material = mat_ship;
        isBlueActive = false;
        winCondition = false;
        pew = GetComponent<AudioSource>();
        //endSpeed = -3;
        //rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        myTime = myTime + Time.deltaTime;

        if (!rail)
            return;

        if (!isCompleted)
            Play(!isReversed);

        //if (winCondition == false)
       // {

            if (Input.GetKey("right"))
            {
                speed = moveSpeed;

            }
            if (Input.GetKey("left"))
            {
                speed = -moveSpeed;
                
            }

            if (currentSeg != whereAmI)
            {
                speed = 0f;
                whereAmI = currentSeg;
            }

            if (Input.GetKey("up") && myTime > nextFire)
            {
                if (!isBlueActive)
                {
                    nextFire = myTime + fireDelta;
                    Instantiate(Shoot, ShootSpawn.position, Quaternion.identity);
                    nextFire = nextFire - myTime;
                    myTime = 0.0F;
                    pew.Play();
                }
                else
                {
                    nextFire = myTime + fireDelta;
                    Instantiate(Shoot, ShootSpawn.position, Quaternion.identity);
                    Instantiate(Shoot, ShootSpawnRight.position, Quaternion.identity);
                    Instantiate(Shoot, ShootSpawnLeft.position, Quaternion.identity);
                    nextFire = nextFire - myTime;
                    myTime = 0.0f;
                    threepew.Play();
                isBlueActive = false;
                }
            }


            if (YellowPowerup._shielded == true)
            {
                rend.material = mat_shielded;
            }
            else
            {
                rend.material = mat_ship;
            }
       // }
       /* if (winCondition == true)
        {
            rb.isKinematic = false;
            transform.Translate(Vector3.back * endSpeed * Time.deltaTime);
            Tube.tubeSpeed = 0;
        }*/
        
    }

    private void Play(bool forward = true)
    {
        float m = (rail.nodes[currentSeg + 1].position - rail.nodes[currentSeg].position).magnitude;
        float s = (Time.deltaTime * 1 / m) * speed;
        //transition += (forward) ? s : -s;
        transition += s;


        if (transition > 1)
        {
            transition = 0;
            currentSeg++;
            if (currentSeg == rail.nodes.Length - 1)
            {
                if (isLooped)
                {
                    if (PingPong)
                    {
                        transition = 1;
                        currentSeg = rail.nodes.Length - 2;
                        isReversed = !isReversed;

                    }
                    else
                    {
                        currentSeg = 0;
                    }

                }
                else
                {
                    isCompleted = true;
                    return;
                }
            }
        }
        else if (transition < 0)
        {
            transition = 1;
            currentSeg--;
            if (currentSeg == -1)
            {
                if (isLooped)
                {
                    if (PingPong)
                    {
                        transition = 0;
                        currentSeg = 0;
                        isReversed = !isReversed;

                    }
                    else
                    {
                        currentSeg = rail.nodes.Length - 2;
                    }

                }
                else
                {
                    isCompleted = true;
                    return;
                }
            }
        }

        transform.position = rail.PositionOnRail(currentSeg, transition, mode);
        transform.rotation = rail.Orientation(currentSeg, transition);
        //speed = 0f;

    }

}


