using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeginEnemyMovement : MonoBehaviour {

    public GameObject enemy;
    Rigidbody2D enemyRigid;
    public float forceX = 10, forceY = 0;
    public float torque = 0;

	// Use this for initialization
	void Start () {
        enemyRigid = enemy.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            enemyRigid.AddForce(new Vector2(forceX, forceY));
            enemyRigid.AddTorque(torque);
        }
    }
}
