using UnityEngine;
using System.Collections;

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

    private void Update()
    {
        myTime = myTime + Time.deltaTime;

        if (!rail)
            return;

        if (!isCompleted)
            Play(!isReversed);

        if (Input.GetKey("right"))
        {
            speed = moveSpeed;

        }
        if (Input.GetKey("left"))
        {
            speed = -moveSpeed;
        }

        if (currentSeg != whereAmI && !Input.GetKey("left") && !Input.GetKey("right"))
        {
            speed = 0f;
            whereAmI = currentSeg;
        }



        if (Input.GetButton ("Fire1") && myTime > nextFire)
        {
            if (!isBlueActive)
            {
                nextFire = myTime + fireDelta;
                Instantiate(Shoot, ShootSpawn.position, Quaternion.identity);
                nextFire = nextFire - myTime;
                myTime = 0.0F;
            }
            else
            {
                nextFire = myTime + fireDelta;
                Instantiate(Shoot, ShootSpawn.position, Quaternion.identity);
                Instantiate(Shoot, ShootSpawnRight.position, Quaternion.identity);
                Instantiate(Shoot, ShootSpawnLeft.position, Quaternion.identity);
                nextFire = nextFire - myTime;
                myTime = 0.0f;

            }
          
        }

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
        //speed = 0f;

    }

}

