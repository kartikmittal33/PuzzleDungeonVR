using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleTimeIndicator : MonoBehaviour
{
    private void Update () {
        GetComponent<ParticleSystem>().startColor = TimeManager.instance.slowMotion ? Color.red : Color.green;
    }
}
