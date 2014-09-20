using UnityEngine;
using System.Collections;

public class KameraZoom : MonoBehaviour {

	public GameObject matka;
	public float zoomSpeed;
	

	void Update () 
	{
		if(Input.GetAxis("Mouse ScrollWheel") != 0)
		{
			matka.transform.rigidbody.velocity = (new Vector3(0,1,1) * Input.GetAxis("Mouse ScrollWheel") * zoomSpeed);
		}
	}
}
