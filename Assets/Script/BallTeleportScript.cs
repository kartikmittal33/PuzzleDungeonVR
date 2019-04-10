using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class BallTeleportScript : MonoBehaviour
{

    public GameObject prefab;
    public Rigidbody attachPoint;

    public SteamVR_Action_Boolean trig = SteamVR_Input.GetAction<SteamVR_Action_Boolean>("InteractUI");

    SteamVR_Behaviour_Pose trackedObj;
    FixedJoint joint;
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
    }

    private void FixedUpdate()
    {
        if (joint == null && trig.GetStateDown(trackedObj.inputSource))
        {
            prefab.transform.position = attachPoint.transform.position;

            joint = prefab.AddComponent<FixedJoint>();
            joint.connectedBody = attachPoint;
        }
        else if (joint != null && trig.GetStateUp(trackedObj.inputSource))
        {
            GameObject go = joint.gameObject;
            Rigidbody rigidbody = go.GetComponent<Rigidbody>();
            Object.DestroyImmediate(joint);
            joint = null;

            Transform origin = trackedObj.origin ? trackedObj.origin : trackedObj.transform.parent;
            if (origin != null)
            {
                rigidbody.velocity = origin.TransformVector(trackedObj.GetVelocity());
                rigidbody.angularVelocity = origin.TransformVector(trackedObj.GetAngularVelocity());
            }
            else
            {
                rigidbody.velocity = trackedObj.GetVelocity();
                rigidbody.angularVelocity = trackedObj.GetAngularVelocity();
            }

            rigidbody.maxAngularVelocity = rigidbody.angularVelocity.magnitude;
        }
    }




}
