using UnityEngine;
using System.Collections;

public class Upgrade_menu : MonoBehaviour {

public GameObject baza;
	public Texture tekstura;
	float kosztCzlowieka=15;
	float kosztPlecaka=3;
	int poziomPlecaka=0;
	int iloscLudzi=0;
	public GameObject human;
	int maxIloscSmieci;


void start()
{
		baza = GameObject.FindWithTag("Finish");
}

	void OnGUI ()
	{
		GUI.contentColor = Color.black;
		GUI.Label(new Rect(20,20,200,20),"Ilość pieniędzy: "+baza.GetComponent<Kasa>().iloscKasy.ToString());		
		GUI.Label(new Rect(20,45,200,20),"Ilość śmieci: "+baza.GetComponent<Kasa>().player[0].GetComponent<Plecak>().aktualnaIloscSmieci.ToString()+"/"+baza.GetComponent<Kasa>().player[0].GetComponent<Plecak>().maxIloscSmieci.ToString());
		
		
		if (Input.GetKey(KeyCode.Q))
		{
			GUI.contentColor = Color.white;
			Time.timeScale = 0.25f;
			GUI.DrawTexture(new Rect(Screen.width/2 - tekstura.width/2,Screen.height/2 - tekstura.height/2,tekstura.width,tekstura.height), tekstura);
			GUI.BeginGroup(new Rect(80,80,400,600));
			{
				GUI.Label(new Rect(20,20,200,20),"Ilosc pracownikow: ");			
			
				GUI.Label(new Rect(210,20,140,20),"koszt następnego: "+kosztCzlowieka.ToString());
				if(GUI.Button(new Rect(150,20,40,20), iloscLudzi.ToString()))
				{
						if( baza.GetComponent<Kasa>().iloscKasy>=kosztCzlowieka)
					{
						iloscLudzi++;
						baza.GetComponent<Kasa>().iloscKasy-=kosztCzlowieka;
						kosztCzlowieka += Mathf.CeilToInt( kosztCzlowieka*25/100);
						Instantiate(human,baza.transform.position,Quaternion.identity);
					}
				}else
					GUI.Label(new Rect(20,50,200,20),"Poziom plecaka: ");
				GUI.Label(new Rect(210,50,140,20),"koszt następnego: "+kosztPlecaka.ToString());
				if(GUI.Button(new Rect(150,50,40,20), poziomPlecaka.ToString()))
				{
					if( baza.GetComponent<Kasa>().iloscKasy>=kosztPlecaka)
					{
						poziomPlecaka++;
						baza.GetComponent<Kasa>().iloscKasy-=kosztPlecaka;
						kosztPlecaka += Mathf.CeilToInt( kosztPlecaka*25/100);
						for(int i=0;i<baza.GetComponent<Kasa>().player.Length;i++)
						{
							baza.GetComponent<Kasa>().player[i].GetComponent<Plecak>().maxIloscSmieci+=3;
						}
					}
				}
			}
			
		}
		else
		{
			Time.timeScale = 1;
		}
		
		
	
		
		
		
		
		
	}
}
