using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowAnimationWithTime : MonoBehaviour
{
    void Update()
    {
		GetComponent<Animator>().speed = TimeManager.instance.slowMotion ? 1.0f : 1.5f;
    }
}
