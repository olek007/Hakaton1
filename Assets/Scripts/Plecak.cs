using UnityEngine;
using System.Collections;

public class Plecak : MonoBehaviour
{

	public GameObject baza;
	public int aktualnaIloscSmieci = 0;
	public int maxIloscSmieci = 5;

	void Start()
	{
		baza = GameObject.FindWithTag("Finish");
		maxIloscSmieci = baza.GetComponent<Kasa>().player[0].GetComponent<Plecak>().maxIloscSmieci;
		gameObject.GetComponent<NavMeshAgent>().speed = baza.GetComponent<Kasa>().player[0].gameObject.GetComponent<NavMeshAgent>().speed;
		gameObject.GetComponent<NavMeshAgent>().acceleration = baza.GetComponent<Kasa>().player[0].gameObject.GetComponent<NavMeshAgent>().acceleration;
	}

	void iloscSmieciMax(int smieci)
	{
		maxIloscSmieci = smieci;
	}

}
