using UnityEngine;
using System.Collections;

public class Plecak : MonoBehaviour {

	public int aktualnaIloscSmieci=0;
	public int maxIloscSmieci=5;
	public GameObject baza;


	void Start () 
	{
		baza = GameObject.FindWithTag("Finish");
		maxIloscSmieci=baza.GetComponent<Kasa>().player[0].GetComponent<Plecak>().maxIloscSmieci;
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
	
	void iloscSmieciMax(int smieci)
	{
		maxIloscSmieci = smieci;
	}
}
