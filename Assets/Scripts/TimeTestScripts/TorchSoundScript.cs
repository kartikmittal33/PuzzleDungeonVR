using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorchSoundScript : MonoBehaviour
{
    AudioSource sound;

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

    public void SlowMotion()
    {
        Debug.Log("call slomo ");
        sound.pitch = 0.3f;
    }

    public void NormalMotion()
    {
        sound.pitch = 1;
    }

}
