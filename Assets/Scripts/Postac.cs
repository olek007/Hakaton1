using UnityEngine;
using System.Collections;

public class Postac : MonoBehaviour
{

	public Camera kamera;
	private NavMeshAgent agent;
	private Ray dest;
	private RaycastHit hit;
	private Vector3 mouseSkrin;

	void Start()
	{
		agent = GetComponent<NavMeshAgent>();
	}

	void Update()
	{
		if (!Input.GetKey(KeyCode.Q))
		{
			if (Input.GetMouseButtonDown(0))
			{
				dest = kamera.ScreenPointToRay(Input.mousePosition);
				if (Physics.Raycast(dest, out hit))
				{
					agent.SetDestination(hit.point);
				}
			}
		}
	}

}
