using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoderStartThrow : MonoBehaviour {

    public GameObject coder;
    public bool set = true;
    Animator animator;

	// Use this for initialization
	void Start () {
        animator = coder.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            animator.SetBool("Start", set);
        }
    }
}
