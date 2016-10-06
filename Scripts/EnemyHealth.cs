using UnityEngine;
using System.Collections;

public class EnemyHealth : MonoBehaviour {

	public int enemyHealth;

	public GameObject deathEffect;

	public int pointsOnDeath;

	public AudioClip killEnemy;

	float soundVolume = 3.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (enemyHealth <= 0) {
			Instantiate (deathEffect, transform.position, transform.rotation);
			AudioSource.PlayClipAtPoint (killEnemy, transform.position, soundVolume);
			Destroy(gameObject);
		}
	
	}

	public void GiveDamage(int damageToGive)
	{
		enemyHealth -= damageToGive;
	}
}
