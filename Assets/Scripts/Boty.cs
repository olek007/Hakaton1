using UnityEngine;
using System.Collections;

public class Boty : MonoBehaviour
{
	
	public GameObject gameStatus;
	public GameObject baza;
	private NavMeshAgent agent;
	private bool czyZbierac = true;
	private int nrSmiecia = 0;
	private float dystans;

	void Start()
	{
		agent = GetComponent<NavMeshAgent>();
		gameStatus = GameObject.FindWithTag("Respawn");
		baza = GameObject.FindWithTag("Finish");

	}


	void Update()
	{
		if (Time.time > 2.0f)
		{
			if (czyZbierac)
			{
				if (gameObject.GetComponent<Plecak>().aktualnaIloscSmieci < gameObject.GetComponent<Plecak>().maxIloscSmieci)
				{
					if (!agent.hasPath)
					{
						dystans = 200000.0f;
						for (int i = 0; i < gameStatus.GetComponent<Spawning>().celeBotow.Count; i++)
						{
							if (Vector3.Distance(gameObject.transform.position, gameStatus.GetComponent<Spawning>().celeBotow[i].transform.position) < dystans)
							{
								dystans = Vector3.Distance(gameObject.transform.position, gameStatus.GetComponent<Spawning>().celeBotow[i].transform.position);
								nrSmiecia = i;
							}
						}
						agent.SetDestination(gameStatus.GetComponent<Spawning>().celeBotow[nrSmiecia].transform.position);
						gameStatus.GetComponent<Spawning>().celeBotow.RemoveAt(nrSmiecia);
					}

					if(Vector3.Distance(gameObject.transform.position,agent.destination)<=2.0f)
					{
						agent.SetDestination(gameObject.transform.position);
					}
				}
				else
				{
					agent.SetDestination(baza.transform.position);
					czyZbierac = false;
				}
			}
			else
			{
				if (gameObject.GetComponent<Plecak>().aktualnaIloscSmieci <= 0)
				{
					czyZbierac = true;
					agent.SetDestination(gameObject.transform.position);
				}
			}
		}
	}

}
