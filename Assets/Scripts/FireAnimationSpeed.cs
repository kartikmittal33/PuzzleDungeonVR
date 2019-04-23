using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FireAnimationSpeed : MonoBehaviour
{
    private ParticleSystem ps;

    void Start()
    {
        ps = GetComponent<ParticleSystem>();
    }

    void Update()
    {
        var main = ps.main;
        if(TimeManager.instance.slowMotion)
        {
            Debug.Log("sm");
            main.simulationSpeed = 0.4f;
        }
        else
        {
            main.simulationSpeed = 1;
        }
    }
}