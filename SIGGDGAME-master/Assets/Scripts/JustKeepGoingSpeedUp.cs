using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JustKeepGoingSpeedUp : MonoBehaviour {

    private PlayerMovement target;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            target = col.GetComponent<PlayerMovement>();
            target.increaseMovementSpeed();
        }
    }
}
