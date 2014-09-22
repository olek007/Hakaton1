using UnityEngine;
using System.Collections;

public class ArrowsControl : MonoBehaviour
{

	public GameObject baza;

	void Start()
	{
		baza = GameObject.FindWithTag("Finish");
	}

	void Update()
	{
		for(int i=0;i<baza.GetComponent<Kasa>().arrow.Length;i++)
		{
			baza.GetComponent<Kasa>().arrow[i].transform.position = new Vector3(baza.GetComponent<Kasa>().player[i].transform.position.x, baza.GetComponent<Kasa>().player[i].transform.position.y + 4.8f, baza.GetComponent<Kasa>().player[i].transform.position.z);
		}
	}
}
