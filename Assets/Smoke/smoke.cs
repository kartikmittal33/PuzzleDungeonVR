using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smoke : MonoBehaviour
{
    void Update()
    {
        if(TimeManager.instance.slowMotion)
        {
            GetComponent<Renderer>().enabled = true;
        }
        else
        {
            GetComponent<Renderer>().enabled = false;
        }
    }
}
