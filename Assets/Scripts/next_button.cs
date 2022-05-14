using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class next_button : MonoBehaviour
{
    public GameObject toSetActive1, toSetActive2, setDisable1, setDisable2;

    public void ChangeScene()
    {
        toSetActive1.SetActive(true);
        toSetActive2.SetActive(true);
        setDisable1.SetActive(false);
        setDisable2.SetActive(false);
    }
}
