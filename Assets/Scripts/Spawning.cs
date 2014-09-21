using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Spawning : MonoBehaviour 
{
	public List<GameObject> smieci;
	public List<GameObject> celeBotow;
	public GameObject prefabSmieci;
	public int maxSmieci = 25;
	int randX;
	int randY;

	void Start()
	{
		for(int i=0;i<maxSmieci;i++)
		{
		do{
			randX=Random.Range(-145,45);
			randY=Random.Range(-45,40);
			}while(randX>-145 &&randX<-92 && randY<40 && randY>23);
			GameObject nowySmiec = Instantiate(prefabSmieci,new Vector3(randX,-2.0f,randY),Quaternion.identity) as GameObject;
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
}
