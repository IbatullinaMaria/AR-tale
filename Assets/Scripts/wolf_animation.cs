using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class wolf_animation : MonoBehaviour
{
    /*private GameObject wolf, s2;
    private Vector3 wPos, fixPos; 
    public Vector3 direction;

    // Start is called before the first frame update
    void Start()
    {
        fixPos = (-0.0118f, 0.0756f, 0.0f);
        wolf = GameObject.Find("Magic wolf render");
        wPos = GameObject.Find("Magic wolf render").transform.position;
        s2 = GameObject.Find ("scene2");
    }

    // Update is called once per frame
    void Update()
    {
        if  ((s2.activeSelf == true) && (wolf.transform.position != fixPos))
        {
            //wolf.transform.position = wolf.transform.position + (0.1f, 0.0f, 0.0f);
            wolf.transform.Translate(direction * Time.deltaTime);
            wPos = wolf.transform.position;
        }
    }*/
    private GameObject s2, posS, posE;
    private Vector3 startPos, endPos;
    public float step;
    private float progress;

    private Animator animator;

    void Start ()
    {
        transform.position = startPos;
        animator = GetComponent<Animator>();
        s2 = GameObject.Find ("scene2");
    }

    void FixedUpdate () 
    {
        if (s2.activeSelf == true)
        {
            posS = GameObject.Find ("poss");
            startPos = posS.transform.position;
            posE = GameObject.Find ("pose");
            endPos = posE.transform.position;
            Walk();
        }
        Debug.Log(transform.position);
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
