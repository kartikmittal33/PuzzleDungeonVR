using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{

    static BoxCollider boxCollider;

    private void Awake()
    {
        boxCollider = GetComponent<BoxCollider>();
    }
    void Update()
    {

    }

    public static void SlowMotion()
    {
        boxCollider.isTrigger = false;
    }

    public static void Normal()
    {
        boxCollider.isTrigger = true;
    }

}
