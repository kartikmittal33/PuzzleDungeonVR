using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBoxScript : MonoBehaviour
{
    public GameObject obj1;
    public GameObject obj2;

    public float timeScale;
    public float speed;

    private Vector3 pos1;
    private Vector3 pos2;

    void Start()
    {
        pos1 = obj1.transform.position;
        pos2 = obj2.transform.position;
    }

    void Update()
    {
        //smooth sin option
        transform.position = Vector3.Lerp(pos1, pos2, (Mathf.Sin(timeScale * speed * Time.time) + 1.0f) / 2.0f);

        //direct option
        //transform.position = Vector3.Lerp(pos1, pos2, Mathf.PingPong(timeScale * speed * Time.time, 1.0f));
    }
}
