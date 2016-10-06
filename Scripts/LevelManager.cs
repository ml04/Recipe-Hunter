using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public GameObject currentCheckpoint;

	private PlayerController player;
	private float gravityStore;

	public GameObject deathParticle;
	public GameObject respawnParticle;

	public float respawnDelay;

	private CameraController camera;

	public HealthManager healthManager;

	public AudioClip playerDying;

	// Use this for initialization
	void Start () {
		player = FindObjectOfType<PlayerController> ();
		camera = FindObjectOfType<CameraController> ();
		healthManager = FindObjectOfType<HealthManager> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void RespawnPlayer() //stvori igrača na mjestu checkpointa
	{
		StartCoroutine ("RespawnPlayerCo");
	}

	public IEnumerator RespawnPlayerCo()
	{
		Instantiate (deathParticle, player.transform.position, player.transform.rotation); //stvori particle za uništavanje
		AudioSource.PlayClipAtPoint(playerDying, player.transform.position, 0.2f);
		player.enabled = false; //ne dozvoljava upravljanje objektom nakon smrti
		player.GetComponent<Renderer>().enabled = false;//uklanja igrača nakon smrti
		camera.isFollowing = false;
		gravityStore = player.GetComponent<Rigidbody2D>().gravityScale;
		player.GetComponent<Rigidbody2D>().gravityScale = 0f;
		player.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
		yield return new WaitForSeconds (respawnDelay); //pričekaj nakon smrti
		player.GetComponent<Rigidbody2D>().gravityScale = gravityStore;
		player.transform.position = currentCheckpoint.transform.position; //stvori se na checkpointu
		player.knockbackCount = 0; //sprečava da baci igrača čim se spawnira
		player.enabled = true;
		player.GetComponent<Renderer>().enabled = true;
		healthManager.FullHealth ();
		healthManager.isDead = false;
		camera.isFollowing = true;
		Instantiate (respawnParticle, currentCheckpoint.transform.position, currentCheckpoint.transform.rotation); //stvori particle za stvaranje

	}

	public void LoadLevel(string name)
	{
		Application.LoadLevel (name);
	}

	public void QuitGame()
	{
		Debug.Log ("Game is over");
		Application.Quit ();
	}
}
