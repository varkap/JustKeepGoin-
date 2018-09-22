using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowingCamera : MonoBehaviour
{

    GameObject[] targets;
    GameObject target;

    // Use this for initialization
    void Start()
    {
        targets = GameObject.FindGameObjectsWithTag("Player");
        target = targets[0];
    }

    // Update is called once per frame
    void Update()
    {
        if (targets != null)
        {
            transform.position = new Vector3(target.transform.position.x, this.transform.position.y, this.transform.position.z);
        }
    }
}
