using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EndingText : MonoBehaviour 
{

	public Text text;

	public Text Previous;
	public Text Next;

	enum States { first, second, third, fourth }

	States myState;

	// Use this for initialization
	void Start () 
	{
		myState = States.first;
	}

	// Update is called once per frame
	void Update () 
	{
		if (myState == States.first) first();
		else if (myState == States.second) second();
		else if (myState == States.third) third();
		else if (myState == States.fourth) fourth();
	}

	// PRE-GAME
	void first()
	{
		text.text = "Pao je i veliki Adolf Hitler. Ni ne slutivši neslutivo, ostao je nadvladan u borbi za recept ovog doba.. \n" +
			"Mnoštvo dvostrukih agenata kao i tucet obavještajnih službi nije zaustavilo našeg junaka u njegovom naumu. \n" +
			"Tajni njemački recept bavarskog kiselog kupusa sa svinjskim mesom uz dodatak Schwarzwald torte trenutno se nalazi u rukama našega junaka. \n" +
			"5 vremenom prokušanih recapata je osigurano. Vrijeme je za pogled na njih.... ";
		
		if (Input.GetKeyDown("n")) myState = States.second;

		Previous.enabled = false;
		Next.enabled = true;
	}
	void second()
	{
		text.text = "RECEPTI : \n\n" +
			"1. Crna mačka u umaku od grožđica, đumbira i narančinog soka.\n" +
			"2. Gyros u umaku od češnjaka i origana. \n" +
			"3. Spaghette Bolognese uz dodatak parmezana i crnog vina.\n" +
			"4. Prasetina u umaku sa svježe spravljenjim pivom.\n" +
			"5. Bavarski kiseli kupus sa svinjskim mesom uz Schwarzwald tortu.\n";

		if (Input.GetKeyDown("n")) myState = States.third;
		else if (Input.GetKeyDown("p")) myState = States.first;

		Previous.enabled = true;
		Next.enabled = true;
	}
	void third()
	{
		text.text = "SADAŠNJOST....\n\n" +
		"Nepoznati student(brucoš) : Kolega, Campus ima odličnu hranu...\n\n" +
		"Nepoznati student(apsolvent preddiplomac) :  Ne mogu vjerovati da tek sada Campus ima ovako dobar jelovnik\n\n" +
		"Nepoznati student(apsolvent diplomac) : Zašto nisam rođen godinama kasnije. Zbog ovakvog jelovnika mi je žao što ću završiti studij...\n\n ";

		if (Input.GetKeyDown("n")) myState = States.fourth;
		else if (Input.GetKeyDown("p")) myState = States.second;

		Next.enabled = true;
		Previous.enabled = true;
	}
	void fourth()
	{
		text.text = "POMOĆNI KUHARI\n\n" +
			"Programer : Matija Lekić\n\n" +
			"Dizajner : Hrvoje Hajduković\n\n" +
			"DIzajner : Matej Umiljanović\n\n ";

		Next.enabled = false;
		Previous.enabled = false;
	}
}





