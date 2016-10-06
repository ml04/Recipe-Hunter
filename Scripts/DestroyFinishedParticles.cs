using UnityEngine;
using System.Collections;

public class DestroyFinishedParticles : MonoBehaviour {

	private ParticleSystem thisParticleSystem;

	// Use this for initialization
	void Start () {
		thisParticleSystem = GetComponent<ParticleSystem> ();
	}
	
	// Update is called once per frame
	void Update () {

		if (thisParticleSystem.isPlaying) // uništavanje particle-a
			return;                       // koji završe 
		Destroy (gameObject);		      // svoje trajanje
	}

	void OnBecameInvisible()
	{
		Destroy (gameObject);
	}
}
