using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float FireRate = 1f;
    private float timestamp = 0f;
	private float timestampWalking = 0f;

	public float movingSpeed;
	private float movingVelocity; 
	public float jumpHeight;
	public float walkingRate;

	public Transform groundCheck;
	public float groundCheckRadius;
	public LayerMask whatIsGround;
	private bool grounded;

	public float knockback;
	public float knockbackLength;
	public float knockbackCount;
	public bool knockFromRight;

	private Rigidbody2D myRigidbody2D;


	private Animator anim;

    public Transform firePoint;
    public GameObject playerProjectile;

	public AudioClip jumpSound;
	public AudioClip walkingSound;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
		myRigidbody2D = GetComponent<Rigidbody2D> ();
	}

	void FixedUpdate() //provjeravamo je li igrač na tlu
	{
		grounded = Physics2D.OverlapCircle (groundCheck.position, groundCheckRadius, whatIsGround);
	}
	
	// Update is called once per frame
	void Update () {

		anim.SetBool ("Grounded", grounded); //postavlja se bool vrijednost za tranziciju skoka
	
		if (Input.GetButtonDown ("Jump") && grounded) //izvođenje skoka igrača
		{
			myRigidbody2D.velocity = new Vector2 (myRigidbody2D.velocity.x - 2f, jumpHeight);
			AudioSource.PlayClipAtPoint (jumpSound, transform.position, 0.4f);

		}

        if(Input.GetKeyDown(KeyCode.B) && Time.time >= timestamp)
        {
            Instantiate(playerProjectile, firePoint.position, firePoint.rotation);
            timestamp = Time.time + FireRate;
            

            
        }

		if ((Input.GetKey (KeyCode.RightArrow) || Input.GetKey (KeyCode.LeftArrow)) && Time.time >= timestampWalking && grounded) 
		{
			AudioSource.PlayClipAtPoint (walkingSound, transform.position);
			timestampWalking = Time.time + walkingRate;
		}

		//movingVelocity = 0f;

		movingVelocity = movingSpeed * Input.GetAxisRaw ("Horizontal");

		if (knockbackCount <= 0)  //odbacivanje igrača u zrak pri dodiru s neprijateljem
		{
			myRigidbody2D.velocity = new Vector2 (movingVelocity, myRigidbody2D.velocity.y);
		} else {
			if (knockFromRight)
				myRigidbody2D.velocity = new Vector2 (-knockback, knockback);
			if (!knockFromRight)
				myRigidbody2D.velocity = new Vector2 (knockback, knockback);
			knockbackCount -= Time.deltaTime;
		}		

		anim.SetFloat ("Speed", Mathf.Abs(myRigidbody2D.velocity.x)); //postavljanje float vrijednosti za tranziciju hodanja

		if (myRigidbody2D.velocity.x > 0)  //obrtanje lika ako hoda u suprotnom smjeru
			transform.localScale = new Vector3 (1f, 1f, 1f);
		else if (myRigidbody2D .velocity.x < 0)
			transform.localScale = new Vector3 (-1f, 1f, 1f);

	}


}
