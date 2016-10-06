using UnityEngine;
using System.Collections;

public class FlyerEnemyMove : MonoBehaviour {


    private PlayerController thePlayer;

    public float moveSpeed;

    public float playerRange;

    public LayerMask playerLayer;

    public bool playerInRange;

    public bool moveRight;


    // Use this for initialization
    void Start () {

        thePlayer = FindObjectOfType<PlayerController>();


    }
	
	// Update is called once per frame
	void Update () {

        playerInRange = Physics2D.OverlapCircle(transform.position, playerRange, playerLayer);
        

        if (playerInRange == true)
        {


           transform.position = Vector3.MoveTowards(transform.position, thePlayer.transform.position, moveSpeed * Time.deltaTime);
            if(thePlayer.transform.position.x < transform.position.x)
                transform.localScale=new Vector3 (1f, 1f, 1f);
            if(thePlayer.transform.position.x > transform.position.x)
                transform.localScale = new Vector3(-1f, 1f, 1f);
        }
	}

    void OnDrawGizmosSelected ()
    {
        Gizmos.DrawSphere(transform.position, playerRange);
    }

}
