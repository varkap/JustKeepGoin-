using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PermitYouWinButton : MonoBehaviour {

    public GameObject player;
    PlayerMovement target;

	// Use this for initialization
	void Start () {
        target = player.GetComponent<PlayerMovement>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            target.allowTheIWinButton();
        }
    }
}
