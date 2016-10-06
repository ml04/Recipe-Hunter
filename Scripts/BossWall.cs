using UnityEngine;
using System.Collections;

public class BossWall : MonoBehaviour {

    

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if(GameObject.FindWithTag("recept") || FindObjectOfType<BossHealthManager>() || ScoreManager.score < 700)
        {
            return;
        }

        Destroy(gameObject);
	
	}
}
