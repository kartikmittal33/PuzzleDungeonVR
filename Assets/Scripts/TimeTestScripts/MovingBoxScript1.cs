using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBoxScript1 : MonoBehaviour
{
    public GameObject obj1;
    public GameObject obj2;
    public float speed;

    private float localTimeScale = 1.0f;

    private Vector3 pos1;
    private Vector3 pos2;

    void Start()
    {
        pos1 = obj1.transform.position;
        pos2 = obj2.transform.position;
    }

    void Update()
    {
        if(TimeManager.instance.slowMotion)
        {
            localTimeScale = TimeManager.instance.motionFactor;
        }
        else
        {
            localTimeScale = 1.0f;
        }

        //smooth sin option
        transform.position = Vector3.Lerp(pos1, pos2, (Mathf.Sin(localTimeScale * speed * Time.time) + 1.0f) / 2.0f);
    }
}
