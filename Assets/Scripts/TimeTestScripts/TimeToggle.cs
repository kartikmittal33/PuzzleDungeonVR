using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeToggle : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
    }
}
