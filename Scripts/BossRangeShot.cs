using UnityEngine;
using System.Collections;

public class BossRangeShot : MonoBehaviour {



    public float playerRange;

    public GameObject enemyProjectile;

    public PlayerController player;

    public Transform launchPoint;

    public Transform launchPointTwo;

    public float waitBetweenShots;
    private float shotCounter;

    public float waitBetweenShots2;
    private float shotCounter2;




    // Use this for initialization
    void Start()
    {

        player = FindObjectOfType<PlayerController>(); //ovo smo mogli dodat u unityu jer je public player

        shotCounter = waitBetweenShots;
        shotCounter2 = waitBetweenShots2;
    }

    // Update is called once per frame
    void Update()
    {

        Debug.DrawLine(new Vector3(transform.position.x - playerRange, transform.position.y, transform.position.z), new Vector3(transform.position.x + playerRange, transform.position.y, transform.position.z));

        shotCounter -= Time.deltaTime;
        shotCounter2 -= Time.deltaTime;

		if (transform.localScale.x < 0 && player.transform.position.x > transform.position.x && player.transform.position.x < transform.position.x + playerRange && player.transform.position.y < transform.position.y + 2 && player.transform.position.y > transform.position.y - 2 && shotCounter < 0)
        {

            Instantiate(enemyProjectile, launchPoint.position, launchPoint.rotation);
            shotCounter = waitBetweenShots;
            Instantiate(enemyProjectile, launchPointTwo.position, launchPointTwo.rotation);
            shotCounter2 = waitBetweenShots2;

        }

		if (transform.localScale.x > 0 && player.transform.position.x < transform.position.x && player.transform.position.x > transform.position.x - playerRange && player.transform.position.y > transform.position.y - 2f && player.transform.position.y < transform.position.y + 2 && shotCounter < 0)
        {

            Instantiate(enemyProjectile, launchPoint.position, launchPoint.rotation);
            shotCounter = waitBetweenShots;
            Instantiate(enemyProjectile, launchPointTwo.position, launchPointTwo.rotation);
            shotCounter2 = waitBetweenShots2;

        }


    }
}
