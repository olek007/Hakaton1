using UnityEngine;
using System.Collections;

public class SmiecScript : MonoBehaviour {

	public GameObject[] player;
	public GameObject gameStatus;

	void Start()
	{
		player = new GameObject[GameObject.FindGameObjectsWithTag("Player").Length];
		for(int i=0;i<player.Length;i++)
		{
			player[i] = GameObject.FindGameObjectsWithTag("Player")[i];
		}
		gameStatus = GameObject.FindWithTag("Respawn");
	}

	void Update () 
	{
		for(int i=0;i<player.Length;i++)
		{
			if(Vector3.Distance(player[i].transform.position,gameObject.transform.position)<2.0f)
			{
				if(player[i].name=="Bot" && player[i].GetComponent<Boty>().aktualnaIloscSmieci<player[i].GetComponent<Boty>().maxIloscSmieci)
				{
					player[i].GetComponent<Boty>().aktualnaIloscSmieci++;
				}else
				if(player[i].name=="Postac" && player[i].GetComponent<Postac>().aktualnaIloscSmieci<player[i].GetComponent<Postac>().maxIloscSmieci)
				{
					player[i].GetComponent<Postac>().aktualnaIloscSmieci++;
				}
				gameStatus.GetComponent<Spawning>().smieci.Remove(gameObject);
				gameStatus.GetComponent<Spawning>().celeBotow.Remove(gameObject);
				Destroy(gameObject);
			}
		}
	}
}
