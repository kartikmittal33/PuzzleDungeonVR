using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody body;
    void Start()
    {

    }

    private void Awake()
    {
        body = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Floor")
        {
            body.velocity = Vector3.zero;
            body.angularVelocity = Vector3.zero;
            Debug.Log("here");
        }
    }
}
