using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio_play : MonoBehaviour
{
    GameObject self;
    AudioClip clip;

    void Update()
    {
        if (self.activeSelf)
        {
            GetComponent<AudioSource>().PlayOneShot(clip);
        }
    }
}
