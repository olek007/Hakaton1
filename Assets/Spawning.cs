using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Spawning : MonoBehaviour {

	public List<GameObject> smieci;
	public List<GameObject> celeBotow;
	public GameObject prefabSmieci;
	//GameObject nowySmiec;
	public int maxSmieci = 25;
	public float wielkoscMapy = 45;

	void Start()
	{
		for(int i=0;i<maxSmieci;i++)
		{
			GameObject nowySmiec = Instantiate(prefabSmieci,new Vector3(Random.Range(-145,45),-2.0f,Random.Range(-45,40)),Quaternion.identity) as GameObject;
			smieci.Add(nowySmiec);
			celeBotow.Add(nowySmiec);
		}

	}

	void Update () 
	{
		if(smieci.Count<maxSmieci)
		{
			GameObject nowySmiec = Instantiate(prefabSmieci,new Vector3(Random.Range(-145,45),-2.0f,Random.Range(-45,40)),Quaternion.identity) as GameObject;
			smieci.Add(nowySmiec);
			celeBotow.Add(nowySmiec);
		}
	}
	//void usowanieZListy(GameObject objekt)
	//{
	//	smieci.Remove(objekt);
	//}
}
