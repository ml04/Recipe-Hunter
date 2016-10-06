using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MainText : MonoBehaviour 
{

	public Text text;

	public Text Previous;
	public Text Next;

	enum States { first, second, third, fourth, fifth, sixth }

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
		else if (myState == States.fifth) fifth();
		else if (myState == States.sixth) sixth();
	}

	// PRE-GAME
	void first()
	{
		text.text = "VRIJEME RADNJE : 2016. godina\n\n" +
			"MJESTO RADNJE : Ul. kneza Trpimira 2B, 31000, Osijek \n\n" +
		"TEMA : Skup studentskog zbora. Problem prehrane u studentskim kantinama" +
		"\n\nRADNJA: Govor Izv.prof.dr.sc Prodo Ekana, prodekana za nastavu i studente\n";
				
		if (Input.GetKeyDown("n")) myState = States.second;

		Previous.enabled = false;
		Next.enabled = true;
	}
	void second()
	{
		text.text = "Prodo Ekan: „JA IMAM SAN!\n" +
			"Imam san u kojem studenti jedu najfinija jela i delikatese iz cijelog svijeta. \nImam san u kojem pecivo, vilice, " +
			"žlice i noževi stoje na kraju reda. \nU kojem se zna porijeklo svake namirnice, gdje je pire krumpir od pravog krumpira " +
			"a lignje su uistinu lignje. \nSan u kojem su kobasice samo podsjetnik na loša vremena i zabranjene zakonom po članku 13.,  " +
			"Zakona o studentskoj prehrani. \nStudenti, vrijeme je za ustanak, vrijeme je za protest, demonstracije i iskazivanje " +
			"građanskog neposluha za opće dobro. \nStudenti, probudite se!! Svatko……" +
			"( u riječ upada doc.dr.sc Gemo Plejer)....";

		if (Input.GetKeyDown("n")) myState = States.third;
		else if (Input.GetKeyDown("p")) myState = States.first;

		Previous.enabled = true;
		Next.enabled = true;
	}
	void third()
	{
		text.text = "Gemo Plejer: „Stanite!\nPovijest nam govori da ovakve manifestacije nikada nisu donijele dobro malom čovjeku.\n" +
			"Revolucija jede svoju djecu.\nMali pomaci neće riješiti ovu rak-ranu društva, studentsku prehranu.\n" +
			"Predugo je student čekao da mu se hrana probavi kako bi mogao izvršavati svoje studentske obaveze.\n" +
			"Vrijeme je za radikalne mjere.\nPostoji samo jedan način za rješavanje ovog problema.\nJedan misteriozan, kompliciran, " +
			"nesvakidašnji i revolucionaran.\nKolegice i kolege, jeste li spremni za ovaj korak u ljudskoj povijesti?\n" +
			"Jednog dana o ovome će se čitati u knjigama, pričati djeci i unucima. možda čak i igrati računalne igre na tu temu……";

		if (Input.GetKeyDown("n")) myState = States.fourth;
		else if (Input.GetKeyDown("p")) myState = States.second;

		Previous.enabled = true;
		Next.enabled = true;
	}
	void fourth()
	{
		text.text = "Kolegice i kolege, posljednjih par mjeseci, u prostorijama ovog fakulteta, " +
		"ustanovljen je novi kolegij.\nU visokoj tajnosti, pod mojim mentorstvom i okriljem noći, " +
			"razvijen je program „Projekt Razvoja Računalnih igara ( u daljnjem tekstu PRRI)“.\nTajni program u potpunosti je razvijen " +
			"od strane trojice heroja, vizionara, junaka 21. stoljeća, čiji identitet će ostati nepoznat ( u daljnjem tekstu ONI)." +
			"\nONI su razvili jednokratni stroj za putovanje vremenom, na CRODUINU, koristeći C programski jezik, sve preko pokazivača. " +
			"\nNjegova jednokratna upotreba produkt je korištenja vrlo rijetkog materijala " +
		"a to je predložak iz laboratorijskih vježbi za kolegij RUAP koji se pojavio na stranicama LOOMEN više od 4h prije " +
		"same vježbe.";
		
		if (Input.GetKeyDown("n")) myState = States.fifth;
		else if (Input.GetKeyDown("p")) myState = States.third;

		Previous.enabled = true;
		Next.enabled = true;
	}
	void fifth()
	{
		text.text = "Kolegice i kolege, poštovani suradnici, predstavnici studentskog zbora, profesori i vanjski suradnici." +
			"\nTeško mi je priopćiti vam ovako važnu vijest pa ću biti direktan.\nJa ću biti taj koji će upotrijebiti stroj..." +
			"\nONI će me teleportirati u vrijeme početka ljudske civilizacije.\nMoja zadaća će biti pokupiti drevne recepte svih naroda u povijesti civilizacije " +
			"i donjeti ih nazad vama.\nTek tada će studenti uživati u jelima koja zaslužuju.\nJa sada idem.\nMoje putovanje će trajati " +
			"10 godina.\nDoći ću nazad 10 godina stariji.\nVi ćete me opet vidjeti za 2 sekunde zbog dilatacije vremena.";
	
		if (Input.GetKeyDown("n")) myState = States.sixth;
		else if (Input.GetKeyDown("p")) myState = States.fourth;

		Previous.enabled = true;
		Next.enabled = true;
	}
	void sixth()
	{
		text.text = "Gemo Plejer ulazi u stroj i nestaje.\nSvi prisutni ostaju zaleđeni u vremenu." +
			"\nNjegova svijest se prebacuje u doba Egipatske civilizacije.....";

		if (Input.GetKeyDown("p")) myState = States.fourth;

		Next.enabled = false;
		Previous.enabled = true;
	}
}





