using UnityEngine;
using System.Collections;

public class SmiecScript : MonoBehaviour
{

	public GameObject gameStatus;
	public GameObject baza;

	void Start()
	{
		gameStatus = GameObject.FindWithTag("Respawn");
		baza = GameObject.FindWithTag("Finish");
	}

	void Update()
	{
		for (int i = 0; i < baza.GetComponent<Kasa>().player.Length; i++)
		{
			if (Vector3.Distance(baza.GetComponent<Kasa>().player[i].transform.position, gameObject.transform.position) < 2.5f)
			{
				if (baza.GetComponent<Kasa>().player[i].GetComponent<Plecak>().aktualnaIloscSmieci < baza.GetComponent<Kasa>().player[i].GetComponent<Plecak>().maxIloscSmieci)
				{
					baza.GetComponent<Kasa>().player[i].GetComponent<Plecak>().aktualnaIloscSmieci++;
					gameStatus.GetComponent<Spawning>().smieci.Remove(gameObject);
					gameStatus.GetComponent<Spawning>().celeBotow.Remove(gameObject);
					Destroy(gameObject);
				}

			}
		}
	}

}
