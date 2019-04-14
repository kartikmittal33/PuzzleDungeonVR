using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeToggle : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("TRIGGER TIME CHANGE");
        if(other.gameObject.tag == "TimeToggle")
        {
            if(TimeManager.instance.slowMotion == true)
            {
                TimeManager.instance.slowMotion = false;
            }
            else
            {
                TimeManager.instance.slowMotion = true;
            }
        }
    }
}
