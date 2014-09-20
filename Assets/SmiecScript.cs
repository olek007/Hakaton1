using UnityEngine;
using System.Collections;

public class SmiecScript : MonoBehaviour {

	//public GameObject[] player;
	public GameObject gameStatus;
	public GameObject baza;

	void Start()
	{
		/*player = new GameObject[GameObject.FindGameObjectsWithTag("Player").Length];
		for(int i=0;i<player.Length;i++)
		{
			player[i] = GameObject.FindGameObjectsWithTag("Player")[i];
		}*/
		gameStatus = GameObject.FindWithTag("Respawn");
		baza = GameObject.FindWithTag("Finish");
	}

	void Update () 
	{
		for(int i=0;i<baza.GetComponent<Kasa>().player.Length;i++)
		{
			if(Vector3.Distance(baza.GetComponent<Kasa>().player[i].transform.position,gameObject.transform.position)<4.0f)
			{
				if(baza.GetComponent<Kasa>().player[i].GetComponent<Plecak>().aktualnaIloscSmieci<baza.GetComponent<Kasa>().player[i].GetComponent<Plecak>().maxIloscSmieci)
				{
					baza.GetComponent<Kasa>().player[i].GetComponent<Plecak>().aktualnaIloscSmieci++;
					gameStatus.GetComponent<Spawning>().smieci.Remove(gameObject);
					gameStatus.GetComponent<Spawning>().celeBotow.Remove(gameObject);
					Destroy(gameObject);
				}

			}
		}
	}
}
