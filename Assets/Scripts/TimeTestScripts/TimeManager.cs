using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    public static TimeManager instance = null;

    public bool slowMotion;
    public float motionFactor = 0.4f;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);    //if instance not this, then destroy gameObject because singleton
        }
    }

    void Update()
    {
        
    }
}
