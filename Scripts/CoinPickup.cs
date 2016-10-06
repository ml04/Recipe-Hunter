using UnityEngine;
using System.Collections;

public class CoinPickup : MonoBehaviour {

	public int pointsToAdd;
	public GameObject coinPickup;
	public AudioClip pickedUpCoin;
	private float soundVolume = 0.5f;

	void OnTriggerEnter2D (Collider2D other) // ako samo igrač pokupi pickup onda dodaj bodove i uništi pickup
	{
		if (other.GetComponent<PlayerController> () == null)
			return;

		ScoreManager.AddPoints (pointsToAdd);

		Instantiate (coinPickup, gameObject.transform.position, gameObject.transform.rotation);
		AudioSource.PlayClipAtPoint (pickedUpCoin, transform.position, soundVolume);
		Destroy (gameObject);

	}
}
