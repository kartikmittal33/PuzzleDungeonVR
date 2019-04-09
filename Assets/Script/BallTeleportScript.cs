using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class BallTeleportScript : MonoBehaviour
{
    // Start is called before the first frame update
    public SteamVR_Action_Boolean trig;
    public SteamVR_Input_Sources hand;
    public GameObject controller;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(getTrigDown())
        {
            transform.position = controller.transform.position;
            Debug.Log("here");
        }
        if (getTrig())
        {
            transform.position = controller.transform.position;
            Debug.Log(" not here");

        }
    }

    public bool getTrigDown()
    {
        return trig.GetStateDown(hand);
    }
    public bool getTrig()
    {
        return trig.GetState(hand);
    }


}
