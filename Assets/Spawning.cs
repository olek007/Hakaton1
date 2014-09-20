﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Spawning : MonoBehaviour {

	public List<GameObject> smieci;
	public List<GameObject> celeBotow;
	public GameObject prefabSmieci;
	GameObject nowySmiec;
	public int maxSmieci = 25;
	public float wielkoscMapy = 45;

	void Update () 
	{
		if(smieci.Count<maxSmieci)
		{
			nowySmiec = Instantiate(prefabSmieci,new Vector3(Random.Range(-wielkoscMapy,wielkoscMapy),0.5f,Random.Range(-wielkoscMapy,wielkoscMapy)),Quaternion.identity) as GameObject;
			smieci.Add(nowySmiec);
			celeBotow.Add(nowySmiec);
		}
	}
	void usowanieZListy(GameObject objekt)
	{
		smieci.Remove(objekt);
		//smieci.Sort();
	}
}
