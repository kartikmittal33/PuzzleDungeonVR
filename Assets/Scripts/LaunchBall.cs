using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MovingBoxScript1))]
public class LaunchBall : MonoBehaviour
{
	void OnCollisionExit(Collision col)
	{
		if (TimeManager.instance.slowMotion) return;
		var rb = col.gameObject.GetComponent<Rigidbody>();

		rb.AddForce(transform.forward * GetComponent<MovingBoxScript1>().speed * 50);
	}
}
