﻿using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed = 7;
	float pierwiastek_z_dwoch_przez_dwa = Mathf.Sqrt(2)/2;


	void Update () 
	{
		if (Input.GetKey(KeyCode.W) && (Input.GetKey(KeyCode.A)))
		{
			gameObject.transform.rigidbody.velocity = new Vector3(-pierwiastek_z_dwoch_przez_dwa * speed,0, pierwiastek_z_dwoch_przez_dwa * speed);
		}
		else
			if (Input.GetKey(KeyCode.W) && (Input.GetKey(KeyCode.D)))
		{
			gameObject.transform.rigidbody.velocity = new Vector3(pierwiastek_z_dwoch_przez_dwa * speed,0, pierwiastek_z_dwoch_przez_dwa * speed);
		}
		else
			if (Input.GetKey(KeyCode.S) && (Input.GetKey(KeyCode.A)))
		{
			gameObject.transform.rigidbody.velocity = new Vector3(-pierwiastek_z_dwoch_przez_dwa * speed,0, -pierwiastek_z_dwoch_przez_dwa * speed);
		}
		else
			if (Input.GetKey(KeyCode.S) && (Input.GetKey(KeyCode.D)))
		{
			gameObject.transform.rigidbody.velocity = new Vector3(pierwiastek_z_dwoch_przez_dwa * speed,0, -pierwiastek_z_dwoch_przez_dwa * speed);
		}
		else
			if (Input.GetKey(KeyCode.W))
		{
			gameObject.transform.rigidbody.velocity = new Vector3(0,0, speed);
		}
		else
			if (Input.GetKey(KeyCode.S))
		{
			gameObject.transform.rigidbody.velocity = new Vector3(0,0, -speed);
		}
		else
			if (Input.GetKey(KeyCode.A))
		{
			gameObject.transform.rigidbody.velocity = new Vector3(-speed,0, 0);
		}
		else
			if (Input.GetKey(KeyCode.D))
		{
			gameObject.transform.rigidbody.velocity = new Vector3(speed,0, 0);
		}

	

	}


}
