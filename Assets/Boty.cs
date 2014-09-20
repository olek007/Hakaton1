using UnityEngine;
using System.Collections;

public class Boty : MonoBehaviour {

	NavMeshAgent agent;
	public GameObject gameStatus;
	public GameObject baza;
	float dystans;
	int nrSmiecia=0;
	public int aktualnaIloscSmieci=0;
	public int maxIloscSmieci = 5;

	void Start () 
	{
		agent=GetComponent<NavMeshAgent>();
		gameStatus = GameObject.FindWithTag("Respawn");
		baza = GameObject.FindWithTag("Finish");
	}
	

	void Update () 
	{
		if(aktualnaIloscSmieci<maxIloscSmieci)
		{
			dystans = Vector3.Distance(gameObject.transform.position,gameStatus.GetComponent<Spawning>().celeBotow[nrSmiecia].transform.position);
			if(!agent.hasPath)
			{
				for(int i=0;i<gameStatus.GetComponent<Spawning>().celeBotow.Count;i++)
				{
					if(Vector3.Distance(gameObject.transform.position,gameStatus.GetComponent<Spawning>().celeBotow[i].transform.position)<=dystans)
					{
						dystans = Vector3.Distance(gameObject.transform.position,gameStatus.GetComponent<Spawning>().celeBotow[i].transform.position);
						nrSmiecia = i;
					}
				}
				if(dystans>1.0f)
				{
					agent.SetDestination(gameStatus.GetComponent<Spawning>().celeBotow[nrSmiecia].transform.position);
					gameStatus.GetComponent<Spawning>().celeBotow.RemoveAt(nrSmiecia);
				}
			}
		}else
		{
			agent.SetDestination(baza.transform.position);
		}
	}
}
