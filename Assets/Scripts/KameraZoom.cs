using UnityEngine;
using System.Collections;

public class KameraZoom : MonoBehaviour {

	public float zoomSpeed;

	void Update () 
	{
		if(Input.GetAxis("Mouse ScrollWheel") != 0)
		{
			gameObject.transform.rigidbody.velocity = (new Vector3(0,-1,0) * Input.GetAxis("Mouse ScrollWheel") * zoomSpeed);
		}
	}
}
