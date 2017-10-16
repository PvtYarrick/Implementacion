using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour
{
    public Railes rail;

    public PlayMode mode;

    public float speed = 5f;
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
        if (!rail)
            return;

        if (!isCompleted)
            Play(!isReversed);

        if (Input.GetKey("right"))
        {
            speed = 7f;

        }
        if (Input.GetKey("left"))
        {
            speed = -7f;
        }

        if (currentSeg != whereAmI)
        {
            speed = 0f;
            whereAmI = currentSeg;
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

