using UnityEngine;
using System.Collections;

public class BossHealthManager : MonoBehaviour {

    public static int enemyHealth=30; // da mozemo koristi u player projectile controleru kada dode do sudara sa bossom 
                                        // i da se moze koristi u GiveDamage funkciji
                                        // tu se definira HP bossa
    public GameObject deathEffect;

    public int pointsOnDeath;

	public AudioClip bossDeathSound;



   

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (enemyHealth <= 0)
        {
            Instantiate(deathEffect, transform.position, transform.rotation);
			AudioSource.PlayClipAtPoint (bossDeathSound, transform.position);
            Destroy(gameObject);
        }

    }

    public static void GiveDamage(int damageToGiveBoss)
    {
        enemyHealth -= damageToGiveBoss;
    }
}
