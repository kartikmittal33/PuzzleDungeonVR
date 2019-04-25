using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmokeScript : MonoBehaviour
{
    static AudioSource source;
    static Renderer r;

    private void Awake()
    {
        source = GetComponent<AudioSource>();
        r = GetComponent<Renderer>();
    }
    void Update()
    {
        
    }

    public static void SlowMotion()
    {
        r.enabled = true;
        source.loop = true;
        source.Play();
    }

    public static void Normal()
    {
        r.enabled = false;
        source.Stop();
    }
}
