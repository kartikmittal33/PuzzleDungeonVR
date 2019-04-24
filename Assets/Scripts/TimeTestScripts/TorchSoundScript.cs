using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorchSoundScript : MonoBehaviour
{
    static AudioSource sound;

    private void Awake()
    {
        sound = GetComponent<AudioSource>();
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public static void SlowMotion()
    {
        sound.pitch = 0.5f;
    }

    public static void NormalMotion()
    {
        sound.pitch = 1;
    }

}
