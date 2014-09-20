using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed = 4;
	float pierwiastek_z_dwoch_przez_dwa = Mathf.Sqrt(2)/2;
	private Vector3 mouseScreen;
	private Vector3 mouse;
	public Camera kamera;
	Transform rotacja;

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

		mouseScreen.x = Input.mousePosition.x;
		mouseScreen.y = Input.mousePosition.y;
		mouseScreen.z = Input.mousePosition.z;//Camera.current.gameObject.transform.position.y;//kamera.gameObject.transform.position.z;
		mouse = kamera.ScreenToWorldPoint(mouseScreen);
		Debug.Log(mouse);
		gameObject.transform.LookAt(new Vector3(mouse.x,0,mouse.z));
		rotacja.rotation = gameObject.transform.rotation;






	}


}
