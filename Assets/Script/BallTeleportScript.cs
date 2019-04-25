using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class BallTeleportScript : MonoBehaviour
{

    public GameObject prefab;
    public Rigidbody attachPoint;
    public GameObject player;

    public SteamVR_Action_Boolean trig = SteamVR_Input.GetAction<SteamVR_Action_Boolean>("InteractUI");
    public SteamVR_Action_Boolean grip = SteamVR_Input.GetAction<SteamVR_Action_Boolean>("GrabGrip");

    Rigidbody ballBody;
    SteamVR_Behaviour_Pose trackedObj;
    FixedJoint joint;

    private bool insideCollider;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void Awake()
    {
        trackedObj = GetComponent<SteamVR_Behaviour_Pose>();
        ballBody = prefab.GetComponent<Rigidbody>();
    }

    public void LetGo() {
	prefab.transform.parent = null;
	ballBody.isKinematic = false;
	
	
	Transform origin = trackedObj.origin ? trackedObj.origin : trackedObj.transform.parent;
	if (origin != null)
	{
	    ballBody.velocity = origin.TransformVector(trackedObj.GetVelocity());
	    ballBody.angularVelocity = origin.TransformVector(trackedObj.GetAngularVelocity());
	}
	else
	{
	    ballBody.velocity = trackedObj.GetVelocity();
	    ballBody.angularVelocity = trackedObj.GetAngularVelocity();
	}
	
	ballBody.maxAngularVelocity = ballBody.angularVelocity.magnitude;
	prefab.transform.GetChild(0).gameObject.SetActive(true);
    }

    private void FixedUpdate()
    {
        if (trig.GetStateDown(trackedObj.inputSource) && !insideCollider)
        {
            prefab.transform.position = this.transform.position;
            prefab.GetComponent<Renderer>().enabled = true;

           // prefab.transform.SetParent(this.transform);
            prefab.transform.parent = this.transform;

            ballBody.isKinematic = true;
   //         joint = prefab.AddComponent<FixedJoint>();
  //          joint.connectedBody = attachPoint;


            Collider coll = prefab.GetComponent<Collider>();
            coll.material.dynamicFriction = 0.01f;
            coll.material.staticFriction = 0.01f;
            coll.material.bounciness = 1;
	    prefab.transform.GetChild(0).gameObject.SetActive(false);
        }
        else if (trig.GetStateUp(trackedObj.inputSource))
        {
	    LetGo();
        }
        else if(!trig.GetStateDown(trackedObj.inputSource) && BallScript.touchingFloor && prefab.transform.parent == null)
        {
            if (grip.GetStateDown(trackedObj.inputSource))
            {
                player.transform.position = prefab.transform.position;
                prefab.GetComponent<Renderer>().enabled = false;
	    	prefab.transform.GetChild(0).gameObject.SetActive(false);
                Debug.Log("slept");
            }
        }
    }


    private void OnTriggerEnter(Collider col) {
    	insideCollider = true;
    }

    private void OnTriggerExit(Collider col) {
    	insideCollider = false;
    }
}
