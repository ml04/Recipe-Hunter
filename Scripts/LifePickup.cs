using UnityEngine;
using System.Collections;

public class LifePickup : MonoBehaviour {

	private LifeManager lifeSystem;

	public AudioClip lifePickup;

	// Use this for initialization
	void Start () {
		lifeSystem = FindObjectOfType<LifeManager> ();
	}
	
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.name == "Player") 
		{
			lifeSystem.GiveLife ();
			AudioSource.PlayClipAtPoint (lifePickup, other.transform.position);
			Destroy (gameObject);
		}
	}

}
