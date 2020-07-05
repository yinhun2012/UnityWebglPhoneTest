using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundCtrl : MonoBehaviour
{
    public AudioClip clip;
    public AudioSource source;

    void Start()
    {
        
    }

    public void Play()
    {
        source.clip = clip;
        source.volume = 1f;
        source.Play();
    }
}
