using UnityEngine;
using System.Collections;

public class ArrowMove : MonoBehaviour {

	GameObject player;
	void Update () 
	{
		player=GetComponentInChildren<Plecak>().gameObject;
		gameObject.transform.position = new Vector3(player.transform.position.x,player.transform.position.y,player.transform.position.z);
	}
}
