using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Kasa : MonoBehaviour {

	public List<GameObject> ludkiWBazie;
	float wartoscSmiecia = 1;
	public GameObject[] player;
	float timer=0;
	public float iloscKasy=0;
	float szybkoscOddawaniaSmieci=2.0f;
	public GameObject gameStatus;

	void Start()
	{
		gameStatus = GameObject.FindWithTag("Respawn");

	}
	

	void Update ()
	{
		player = new GameObject[GameObject.FindGameObjectsWithTag("Player").Length];
		for(int i=0;i<player.Length;i++)
		{
			player[i] = GameObject.FindGameObjectsWithTag("Player")[i];
		}

	}

	void OnTriggerEnter(Collider col)
	{
		if(col.tag=="Player")
		{
			ludkiWBazie.Add(col.gameObject);
		}
	}

	void OnTriggerExit(Collider col)
	{
		if(col.tag=="Player")
		{
			ludkiWBazie.Remove(col.gameObject);
		}
	}

	void OnTriggerStay(Collider col)
	{
		if(col.tag=="Player")
		{
			for(int i=0;i<ludkiWBazie.Count;i++)
			{
				if(timer>=szybkoscOddawaniaSmieci && col.gameObject.GetComponent<Plecak>().aktualnaIloscSmieci>0)
				{
					iloscKasy+=(int)wartoscSmiecia;
					col.gameObject.GetComponent<Plecak>().aktualnaIloscSmieci--;
				}
			}
			if(timer>szybkoscOddawaniaSmieci)
			{
				timer=0f;
			}
			timer += Time.deltaTime/ludkiWBazie.Count;
		}
	}



}
