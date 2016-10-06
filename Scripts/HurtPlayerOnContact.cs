using UnityEngine;
using System.Collections;

public class HurtPlayerOnContact : MonoBehaviour {

	public int damageToGive;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other) //ako se igrač sudari sa objektom, pozovi RespawnPlayer
	{
		if (other.name == "Player")
		{
			HealthManager.HurtPlayer(damageToGive);
			other.GetComponent<AudioSource>().Play ();

			var player = other.GetComponent<PlayerController> ();
			player.knockbackCount = player.knockbackLength;

			if (other.transform.position.x < transform.position.x)
				player.knockFromRight = true;
			else
				player.knockFromRight = false;
		}
	}
}
