using UnityEngine;
using System.Collections;

public class PlayerProjectileController : MonoBehaviour {

    public float speed;

    public PlayerController player;

    public GameObject deathEffect;

    public float timer = 2.0f;

    public int damageToGiveBoss;

	public AudioClip soundKillEnemy;

	public AudioClip soundKillWizard;

	public AudioClip soundKillWizard2;

	public AudioClip soundKillMagician;

	public AudioClip soundKillKnight;

	public AudioClip soundKillSoldier;

	public AudioClip soundKillDog;

	public AudioClip soundHitWall;

	public AudioClip soundHurtBoss;

	public AudioClip soundHurtFlying;


	// Use this for initialization
	void Start () {
        player = FindObjectOfType<PlayerController>();

        if (player.transform.localScale.x < 0)
            speed = -speed;

        Destroy(gameObject, timer);
	
	}
	
	// Update is called once per frame
	void Update () {

        GetComponent<Rigidbody2D>().velocity = new Vector2(speed, GetComponent<Rigidbody2D>().velocity.y);
       
	
	}

    void OnTriggerEnter2D(Collider2D other)
    {
		/*if(other.tag == "Enemy")
		{
			Instantiate(deathEffect, other.transform.position, other.transform.rotation);
			AudioSource.PlayClipAtPoint (soundKillWizard, other.transform.position);
			Destroy(other.gameObject);
			Destroy(gameObject);
		}*/

		if(other.tag == "Enemy")
		{
			Instantiate(deathEffect, other.transform.position, other.transform.rotation);
			AudioSource.PlayClipAtPoint (soundKillEnemy, other.transform.position);
			Destroy(other.gameObject);
			Destroy(gameObject);
		}


	
		if(other.tag == "Enemy_wizard")
		{
			Instantiate(deathEffect, other.transform.position, other.transform.rotation);
			AudioSource.PlayClipAtPoint (soundKillWizard, other.transform.position);
			Destroy(other.gameObject);
			Destroy(gameObject);
		}

		if(other.tag == "Enemy_wizard_2")
		{
			Instantiate(deathEffect, other.transform.position, other.transform.rotation);
			AudioSource.PlayClipAtPoint (soundKillWizard2, other.transform.position);
			Destroy(other.gameObject);
			Destroy(gameObject);
		}

		if(other.tag == "Enemy_magician")
		{
			Instantiate(deathEffect, other.transform.position, other.transform.rotation);
			AudioSource.PlayClipAtPoint (soundKillMagician, other.transform.position);
			Destroy(other.gameObject);
			Destroy(gameObject);
		}


		if(other.tag == "Enemy_knight")
		{
			Instantiate(deathEffect, other.transform.position, other.transform.rotation);
			AudioSource.PlayClipAtPoint (soundKillKnight, other.transform.position);
			Destroy(other.gameObject);
			Destroy(gameObject);
		}

		if(other.tag == "Enemy_dog")
		{
			Instantiate(deathEffect, other.transform.position, other.transform.rotation);
			AudioSource.PlayClipAtPoint (soundKillDog, other.transform.position);
			Destroy(other.gameObject);
			Destroy(gameObject);
		}

		if(other.tag == "Enemy_soldier")
		{
			Instantiate(deathEffect, other.transform.position, other.transform.rotation);
			AudioSource.PlayClipAtPoint (soundKillSoldier, other.transform.position);
			Destroy(other.gameObject);
			Destroy(gameObject);
		}

        if(other.tag == "Ground")
        {
            print("asdawd");
			AudioSource.PlayClipAtPoint (soundHitWall, transform.position);
            Destroy(gameObject);
        }
        if(other.tag == "Boss")
        {
            BossHealthManager.GiveDamage(damageToGiveBoss);
			AudioSource.PlayClipAtPoint (soundHurtBoss, transform.position);
            Destroy(gameObject);
        }

		if(other.tag == "flying")
		{
			BossHealthManager.GiveDamage(damageToGiveBoss);
			AudioSource.PlayClipAtPoint (soundHurtFlying, transform.position);
			Destroy(gameObject);
		}
        //Destroy(gameObject);
    }
}
