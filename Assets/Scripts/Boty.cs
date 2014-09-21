using UnityEngine;
using System.Collections;

public class Boty : MonoBehaviour {

	NavMeshAgent agent;
	public GameObject gameStatus;
	public GameObject baza;
	float dystans;
	int nrSmiecia=0;
	bool czyZbierac=true;

	void Start () 
	{
		agent=GetComponent<NavMeshAgent>();
		gameStatus = GameObject.FindWithTag("Respawn");
		baza = GameObject.FindWithTag("Finish");

	}
	

	void Update () 
	{
		//(gameStatus.GetComponent<Spawning>().celeBotow.Count>=gameStatus.GetComponent<Spawning>().maxSmieci)//.
		if(Time.time>3.0f)
		{
		if(czyZbierac)
		{//gameObject.GetComponent<Plecak>().maxIloscSmieci
			if(gameObject.GetComponent<Plecak>().aktualnaIloscSmieci<gameObject.GetComponent<Plecak>().maxIloscSmieci)
			{
				if(!agent.hasPath)
				{
						dystans = 200000.0f;

					
						for(int i=0;i<gameStatus.GetComponent<Spawning>().celeBotow.Count;i++)
						{
							if(Vector3.Distance(gameObject.transform.position,gameStatus.GetComponent<Spawning>().celeBotow[i].transform.position)<dystans)
							{
								dystans = Vector3.Distance(gameObject.transform.position,gameStatus.GetComponent<Spawning>().celeBotow[i].transform.position);
								nrSmiecia = i;
							}
						}
							//nrSmiecia =Random.Range(0,gameStatus.GetComponent<Spawning>().celeBotow.Count);
							agent.SetDestination(gameStatus.GetComponent<Spawning>().celeBotow[nrSmiecia].transform.position);
							gameStatus.GetComponent<Spawning>().celeBotow.RemoveAt(nrSmiecia);
				}
			}else
			{
				agent.SetDestination(baza.transform.position);
				czyZbierac=false;
			}
		}else
		{
			if(gameObject.GetComponent<Plecak>().aktualnaIloscSmieci<=0)
			{
				czyZbierac=true;
				agent.SetDestination(gameObject.transform.position);
			}
		}
		}
	}
}
