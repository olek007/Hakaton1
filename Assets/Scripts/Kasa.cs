using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Kasa : MonoBehaviour {

	public List<GameObject> ludkiWBazie;
	float wartoscSmiecia = 1;
	public GameObject[] player;
	float timer=0;
	public int iloscKasy=0;
	float szybkoscOddawaniaSmieci=2.0f;

	void Start()
	{
		player = new GameObject[GameObject.FindGameObjectsWithTag("Player").Length];
		for(int i=0;i<player.Length;i++)
		{
			player[i] = GameObject.FindGameObjectsWithTag("Player")[i];
		}
	}
	

	void Update ()
	{


	}

	void OnTriggerEnter(Collider col)
	{
		if(col.gameObject.tag=="Smiec")
		{
			Destroy(col.gameObject);
		}
		ludkiWBazie.Add(col.gameObject);
	}

	void OnTriggerExit(Collider col)
	{
		ludkiWBazie.Remove(col.gameObject);
	}

	void OnTriggerStay(Collider col)
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
		timer += Time.deltaTime;
	}



}
