using UnityEngine;
using System.Collections;

public class ChangeLevel : MonoBehaviour 
{
	public void LoadLevel(string name)
	{
		Application.LoadLevel (name);
	}

	public void QuitGame()
	{
		Debug.Log ("Game is over");
		Application.Quit ();
	}
}
