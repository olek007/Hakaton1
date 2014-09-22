using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Kasa : MonoBehaviour
{

	public List<GameObject> ludkiWBazie;
	public GameObject[] player;
	public GameObject[] arrow;
	public GameObject gameStatus;
	public float iloscKasy = 0;
	public float szybkoscOddawania = 1;
	private float timer = 0;
	private float wartoscSmiecia = 1;
	private float szybkoscOddawaniaSmieci = 2.0f;
	
	void Start()
	{
		gameStatus = GameObject.FindWithTag("Respawn");
		player = new GameObject[GameObject.FindGameObjectsWithTag("Player").Length];
		for (int i = 0; i < player.Length; i++)
		{
			player[i] = GameObject.FindGameObjectsWithTag("Player")[i];
		}

		arrow = new GameObject[GameObject.FindGameObjectsWithTag("Arrow").Length];
		for (int i = 0; i < arrow.Length; i++)
		{
			arrow[i] = GameObject.FindGameObjectsWithTag("Arrow")[i];
		}
	}

	void OnTriggerEnter(Collider col)
	{
		if (col.tag == "Player")
		{
			ludkiWBazie.Add(col.gameObject);
		}
	}

	void OnTriggerExit(Collider col)
	{
		if (col.tag == "Player")
		{
			ludkiWBazie.Remove(col.gameObject);
		}
	}

	void OnTriggerStay(Collider col)
	{
		if (col.tag == "Player")
		{
			for (int i = 0; i < ludkiWBazie.Count; i++)
			{
				if (timer >= szybkoscOddawaniaSmieci && col.gameObject.GetComponent<Plecak>().aktualnaIloscSmieci > 0)
				{
					iloscKasy += (int)wartoscSmiecia;
					col.gameObject.GetComponent<Plecak>().aktualnaIloscSmieci--;
				}
			}
			if (timer > szybkoscOddawaniaSmieci)
			{
				timer = 0f;
			}
			timer += Time.deltaTime / ludkiWBazie.Count * szybkoscOddawania;
		}
	}

	void dodawanieCzlowieka()
	{
		player = new GameObject[GameObject.FindGameObjectsWithTag("Player").Length];
		for (int i = 0; i < player.Length; i++)
		{
			player[i] = GameObject.FindGameObjectsWithTag("Player")[i];
		}
	}

	void dodawanieStrzalki()
	{
		arrow = new GameObject[GameObject.FindGameObjectsWithTag("Arrow").Length];
		for (int i = 0; i < arrow.Length; i++)
		{
			arrow[i] = GameObject.FindGameObjectsWithTag("Arrow")[i];
		}
	}

}


