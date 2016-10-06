using UnityEngine;
using System.Collections;

public class KeyItemPickUp : MonoBehaviour {
    public int foundItem;
    public GameObject keyItemPickUp;

	public AudioClip recipePickup;

    void OnTriggerEnter2D(Collider2D other) // ako samo igrač pokupi pickup onda dodaj bodove i uništi pickup
    {
        if (other.GetComponent<PlayerController>() == null)
            return;

        KeyItemManager.AddItem(foundItem);

        Instantiate(keyItemPickUp, gameObject.transform.position, gameObject.transform.rotation);
		AudioSource.PlayClipAtPoint (recipePickup, other.transform.position);
        Destroy(gameObject);

    }
}
