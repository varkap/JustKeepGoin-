using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleYAxisCamera : MonoBehaviour {

    public GameObject camera;
    FollowingCamera folCam;

    // Use this for initialization
    void Start () {
        folCam = camera.GetComponent<FollowingCamera>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            folCam.toggleFollowYAxis();
        }
    }
}
