using UnityEngine;
using System.Collections;

public class EnemyProjController : MonoBehaviour {

    public float speed;

    public PlayerController player;

    //public GameObject deathEffect;

    public float timer = 2.0f;

    public int damageToGive;

	public HealthManager health;

    private Rigidbody2D myrigidbody2D;

	public AudioClip hurtPlayerSound;

    // Use this for initialization
    void Start () {



        player = FindObjectOfType<PlayerController>();

		health = GetComponent<HealthManager> ();

        myrigidbody2D = GetComponent<Rigidbody2D>();

        if (player.transform.position.x < transform.position.x)
            speed = -speed;

        Destroy(gameObject, timer);

    }
	
	// Update is called once per frame
	void Update () {

        myrigidbody2D.velocity = new Vector2(speed, myrigidbody2D.velocity.y);

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            //Instantiate(deathEffect, other.transform.position, other.transform.rotation);
            //Destroy(other.gameObject);

            HealthManager.HurtPlayer(damageToGive);

            Destroy(gameObject);

			if (HealthManager.playerHealth > 0) {

				AudioSource.PlayClipAtPoint (hurtPlayerSound, other.transform.position);
			}

        }
        if (other.tag == "Ground")
        {
            Destroy(gameObject);
        }
        //Destroy(gameObject);
    }
}
