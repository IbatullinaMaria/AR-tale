using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class next2 : MonoBehaviour
{
    public GameObject sub3, next3, sub2, selfB;

    public void ChangeScene()
    {
        sub3.SetActive(true);
        next3.SetActive(true);
        sub2.SetActive(false);
        selfB.SetActive(false);
    }
}
