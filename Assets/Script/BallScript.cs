using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallScript : MonoBehaviour
{
    // Start is called before the first frame update
    public static Rigidbody body;
    Collider coll;
    public static bool touchingFloor = true;
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
            touchingFloor = true;
            body.velocity = Vector3.zero;
            body.angularVelocity = Vector3.zero;
            coll.material.dynamicFriction = 1;
            coll.material.staticFriction = 1;
            coll.material.bounciness = 0;

        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.layer == 10)
        {
            touchingFloor = false;
        }

        
   
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 14)
        {
            Debug.Log("exited");

            if (!TimeManager.instance.slowMotion)
            {
                Debug.Log("here");
                Debug.Log(SceneManager.GetActiveScene().name);
                string sceneName = SceneManager.GetActiveScene().name;
                if(sceneName == "1")
                {
                    SceneManager.LoadScene(1);
                }
                else if(sceneName == "2")
                {
                    SceneManager.LoadScene(2);
                }
                
            }
        }
    }
}
