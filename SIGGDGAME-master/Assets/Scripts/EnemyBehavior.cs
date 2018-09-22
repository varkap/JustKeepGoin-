using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyBehavior : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D col, int SceneIndex)
    {
        if (col.CompareTag("Player"))
        {

            SceneManager.LoadScene(SceneIndex);
        }
    }
}
