using UnityEngine;
using System.Collections;

public class HurtEnemyOnContact : MonoBehaviour {

	public int damageToGive;
	public float bounceOnEnemy;

	private Rigidbody2D myRigidbody2D;

	// Use this for initialization
	void Start () {
		myRigidbody2D = transform.parent.GetComponent<Rigidbody2D> ();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other) //ako igrač skoči na glavu neprijatelja, oduzmi mu health
	{
		if (other.tag == "Enemy" || other.tag == "Enemy_knight" || other.tag == "Enemy_soldier") {
			other.GetComponent<EnemyHealth> ().GiveDamage (damageToGive);
			myRigidbody2D.velocity = new Vector2 (myRigidbody2D.velocity.x, bounceOnEnemy);
		}
	}
}
