using UnityEngine;
using System.Collections;

public class Postac : MonoBehaviour {

	NavMeshAgent agent;
	Vector3 mouseSkrin;
	RaycastHit hit;
	public Camera kamera;
	Ray dest;


	void Start()
	{
		agent=GetComponent<NavMeshAgent>();
	}

	void Update () 
	{
		if(Input.GetMouseButtonDown(0))
		{
			dest = kamera.ScreenPointToRay(Input.mousePosition);
			if(Physics.Raycast(dest,out hit))
			{
				agent.SetDestination(hit.point);
			}
		}
	}
}
