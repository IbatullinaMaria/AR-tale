using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

public class scene_control : MonoBehaviour
{
    private GameObject s1, s2;

    void Start()
    {
        s1 = GameObject.Find ("scene1");
        s1.SetActive(true);
        s2 = GameObject.Find ("scene2");
        s2.SetActive(false);
    }

    void Update()
    {
        
    }

}
