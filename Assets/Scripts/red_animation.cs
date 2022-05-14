using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class red_animation : MonoBehaviour
{
    /*private GameObject red, s2;
    private Vector3 rPos; 
    public Vector3 directionR;

    // Start is called before the first frame update
    void Start()
    {
        red = GameObject.Find("red");
        rPos = GameObject.Find("red").transform.position;
        s2 = GameObject.Find ("scene2");
    }

    // Update is called once per frame
    void Update()
    {
        if ((s2.activeSelf == true)&&(s2.activeSelf == true))
        {
            //wolf.transform.position = wolf.transform.position + (0.1f, 0.0f, 0.0f);
            red.transform.Translate(directionR * Time.deltaTime);
            rPos = red.transform.position;
        }
    }*/

    private GameObject s2, red1, red, posS, posE;
    private Vector3 startPos, endPos;
    public float step;
    private float progress;

    private Animator animator;

    void Start ()
    {
        transform.position = startPos;
        animator = GetComponent<Animator>();
        s2 = GameObject.Find ("scene2");
        red1 = GameObject.Find ("red(1)");
        red1.SetActive(false);
    }

    void FixedUpdate () 
    {
        if (s2.activeSelf == true) 
        {
            posS = GameObject.Find ("possR");
            startPos = posS.transform.position;
            posE = GameObject.Find ("poseR");
            endPos = posE.transform.position;
            Walk();
            if (transform.position == endPos)
            {
                //red1 = GameObject.Find ("red(1)");
                red1.SetActive(true);
                red = GameObject.Find ("red");
                red.SetActive(false);
            }
        }
       // Debug.Log(transform.position);
    }

    private void Walk ()
    {
        transform.position = Vector3.Lerp(startPos, endPos, progress);
        progress += step;
        if (transform.position != endPos) 
        {
            animator.SetBool("walk", true);
        }
        else 
        {
            animator.SetBool("walk", false);
        }
        //if (transform.position != endPos) animator.SetBool("idle", false);
        //else animator.SetBool("idle", true);
    }
}
