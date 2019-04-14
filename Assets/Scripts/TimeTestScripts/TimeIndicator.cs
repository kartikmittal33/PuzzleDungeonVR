using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeIndicator : MonoBehaviour
{
    Light light;

    void Start()
    {
        light = GetComponent<Light>();
        light.color = Color.green;
    }

    void Update()
    {
        if(TimeManager.instance.slowMotion)
        {
            light.color = Color.red;
        }
        else
        {
            light.color = Color.green;
        }
    }
}
