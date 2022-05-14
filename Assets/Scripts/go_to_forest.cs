using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class go_to_forest : MonoBehaviour
{
    public GameObject s1, s2, b1, b2, subs2, next2;

    public void ChangeScene()
    {
        s1.SetActive(false);
        s2.SetActive(true);
        b1.SetActive(false);
        b2.SetActive(false);
        subs2.SetActive(true);
        next2.SetActive(true);
    }
}
