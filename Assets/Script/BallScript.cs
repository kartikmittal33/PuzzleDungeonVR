using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    // Start is called before the first frame update
    public static Rigidbody body;
    Collider coll;
    void Start()
    {

    }

    private void Awake()
    {
        body = GetComponent<Rigidbody>();
        coll = GetComponent<Collider>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.layer == 10)
        {
            body.velocity = Vector3.zero;
            body.angularVelocity = Vector3.zero;
            coll.material.dynamicFriction = 1;
            coll.material.staticFriction = 1;
            coll.material.bounciness = 0;
        }
    }
}
