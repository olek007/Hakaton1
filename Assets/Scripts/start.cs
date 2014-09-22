using UnityEngine;
using System.Collections;

public class start : MonoBehaviour
{

	public Texture tekstura;

	void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
			Application.LoadLevel(1);
		}
	}

	void OnGUI()
	{
		GUI.DrawTexture(new Rect(Screen.width / 2 - tekstura.width / 2, Screen.height / 2 - tekstura.height / 2, tekstura.width, tekstura.height), tekstura);
	}

}