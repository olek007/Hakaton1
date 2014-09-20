using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Kasa : MonoBehaviour {

	public List<GameObject> ludkiWBazie;
	float wartoscSmiecia = 1;
	public GameObject[] player;

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
		for(int i=0;i<ludkiWBazie.Count;i++)
		{
			//ludkiWBazie[i].GetComponent<Plecak>()
		}
	}

	void OnTriggerEnter(Collider col)
	{
		ludkiWBazie.Add(col.gameObject);
	}

	void OnTriggerExit(Collider collider)
	{
		ludkiWBazie.Remove(collider.gameObject);
	}


}
