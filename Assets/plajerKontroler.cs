using UnityEngine;
using System.Collections;

public class plajerKontroler : MonoBehaviour {

	Vector3 mouse;
	Vector3 mouseSkrin;
	float gibkosc = 5;
	public Camera kamercia;
	float pierwiastek_z_dwuch_przez_dwa = Mathf.Sqrt(2)/2;

	void Update () 
	{
		if (Input.GetKey(KeyCode.W) && (Input.GetKey(KeyCode.A)))
		{
			gameObject.transform.rigidbody2D.velocity = new Vector2(-pierwiastek_z_dwuch_przez_dwa * gibkosc, pierwiastek_z_dwuch_przez_dwa * gibkosc);
		}
		else
		if (Input.GetKey(KeyCode.W) && (Input.GetKey(KeyCode.D)))
		{
			gameObject.transform.rigidbody2D.velocity = new Vector2(pierwiastek_z_dwuch_przez_dwa * gibkosc, pierwiastek_z_dwuch_przez_dwa * gibkosc);
		}
		else
		if (Input.GetKey(KeyCode.S) && (Input.GetKey(KeyCode.A)))
		{
			gameObject.transform.rigidbody2D.velocity = new Vector2(-pierwiastek_z_dwuch_przez_dwa * gibkosc, -pierwiastek_z_dwuch_przez_dwa * gibkosc);
		}
		else
		if (Input.GetKey(KeyCode.S) && (Input.GetKey(KeyCode.D)))
		{
			gameObject.transform.rigidbody2D.velocity = new Vector2(pierwiastek_z_dwuch_przez_dwa * gibkosc, -pierwiastek_z_dwuch_przez_dwa * gibkosc);
		}
		else
		if (Input.GetKey(KeyCode.W))
		{
			gameObject.transform.rigidbody2D.velocity = new Vector2(0, 1 * gibkosc);
		}
		else
		if (Input.GetKey(KeyCode.S))
		{
			gameObject.transform.rigidbody2D.velocity = new Vector2(0, -1 * gibkosc);
		}
		else
		if (Input.GetKey(KeyCode.A))
		{
			gameObject.transform.rigidbody2D.velocity = new Vector2(-1 * gibkosc, 0);
		}
		else
		if (Input.GetKey(KeyCode.D))
		{
			gameObject.transform.rigidbody2D.velocity = new Vector2(1 * gibkosc, 0);
		}




		mouseSkrin.x = Input.mousePosition.x;
		mouseSkrin.y = Input.mousePosition.y;
		mouseSkrin.z = kamercia.gameObject.transform.position.z;
		
		mouse = kamercia.ScreenToWorldPoint(mouseSkrin);
		//Bo kurwa nie da się napisać:
		//Camera.current.ScreenToWorldPoint(Input.mousePosition);
		//ani tak:
		//Camera.current.ScreenToWorldPoint(mouseSkrin);
		//Trza to rozbić tak jak wyżej.
		//No ja jebie.
		mouse.z = gameObject.transform.position.z;
		gameObject.transform.LookAt(mouse);
		gameObject.transform.Rotate(new Vector3(0, 90, 0));

		if (Input.GetKeyDown(KeyCode.Space))
		{
			if (Network.isServer)
			{
				Network.Connect("127.0.0.1", 23466);
				Debug.Log("Jest kurwa");
			}
			else
			{
				Debug.Log("Ni ma");
			}
		}
	}


	void OnConnectedToServer()
	{
		Debug.Log("damn");
	}




	void Start()
	{
		Network.InitializeServer(4, 23466, false);
	}


	//			inne paściarstwa które się mogą kiedyś tam przydać
	/*
	    GUI.DrawTexture(new Rect(positionOnScreen.x - backWidth / 2, positionOnScreen.y - backHeight / 2, backWidth, backHeight), healthBarFrame);
        GUI.DrawTexture(new Rect(positionOnScreen.x - backWidth / 2, positionOnScreen.y - height / 2, width / ratio, height), healthBar, ScaleMode.ScaleAndCrop);  
	*/
}
