using UnityEngine;
using System.Collections;

public class UsowanieSmieciZBudynkow : MonoBehaviour
{

	public GameObject gameStatus;

	void Start()
	{
		gameStatus = GameObject.FindWithTag("Respawn");
	}

	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Smiec")
		{
			gameStatus.GetComponent<Spawning>().smieci.Remove(col.gameObject);
			gameStatus.GetComponent<Spawning>().celeBotow.Remove(col.gameObject);
			Destroy(col.gameObject);
		}
	}

}
