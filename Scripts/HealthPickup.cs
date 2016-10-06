using UnityEngine;
using System.Collections;

public class HealthPickup : MonoBehaviour {

	public int healthToGive;

	public AudioClip breadEater;


	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.GetComponent<PlayerController>() == null)
		{
			return;
		}

		HealthManager.HurtPlayer (-healthToGive);
		AudioSource.PlayClipAtPoint (breadEater, other.transform.position, 0.4f);
		Destroy (gameObject);
	}
}
