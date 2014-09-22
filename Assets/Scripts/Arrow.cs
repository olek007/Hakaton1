using UnityEngine;
using System.Collections;

public class Arrow : MonoBehaviour
{

	Quaternion fixedRotation;

	void Awake()
	{
		 fixedRotation = transform.rotation;
	}

	void Start()
	{
		gameObject.animation.Play();
	}

	void LateUpdate()
	{
		transform.rotation = fixedRotation;
	}
}
