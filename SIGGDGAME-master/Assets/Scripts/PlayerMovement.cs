using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public int movementSpeed = 700;
    public int maxHorizontalVelocity = 150;
    public int interval = 25;
    public int wallPushoff = 50;
    public int jumpHeight = 500;
    public Animator animator;
    private Rigidbody2D myRigid;
    private BoxCollider2D myBoxCol;
    private Vector2 myBoxColSize, halfBoxColSize;
    private bool nowMoving = false;
    private bool canJump;
    private bool isCrouched = false;
    private int jumpCounter, maxJumps = 1;
    private Quaternion rotation;

    // Use this for initialization
    void Start()
    {
        myRigid = this.GetComponent<Rigidbody2D>();
        myBoxCol = this.GetComponent<BoxCollider2D>();
        rotation = myRigid.transform.rotation;
        myBoxColSize = myBoxCol.size;
        halfBoxColSize = new Vector2(myBoxColSize.x, myBoxColSize.y / 2);
    }

    public void increaseMovementSpeed()
    {
        maxHorizontalVelocity += interval;
        movementSpeed += interval;
    }

    // Update is called once per frame
    void Update()
    {
        myRigid.transform.rotation = rotation;
        animator.SetBool("Moving", myRigid.velocity.x < -.01);

        if (Input.GetAxis("Horizontal") < 0)
        {
            nowMoving = true;
        }
        if (nowMoving && myRigid.velocity.x > -maxHorizontalVelocity)
        {
            myRigid.AddForce(new Vector2(-movementSpeed * Time.deltaTime, 0));
        }
        if (Input.GetAxisRaw("Vertical") > 0 && canJump && jumpCounter < maxJumps)
        {
            myRigid.AddForce(new Vector2(0, jumpHeight));
            jumpCounter++;
            if (myRigid.velocity.x >= 0 && myRigid.velocity.y != 0)
            {
                myRigid.AddForce(new Vector2(wallPushoff + maxHorizontalVelocity, 0));
            }
        }
        if (Input.GetAxisRaw("Vertical") < 0 && canJump && jumpCounter == 0)
        {
            isCrouched = true;
            myBoxCol.size = halfBoxColSize;
        }
        else
        {
            isCrouched = false;
        }
        if (Input.GetAxisRaw("Vertical") >= 0 && !isCrouched)
        {
            myBoxCol.size = myBoxColSize;
        }
        canJump = Input.GetAxis("Vertical") <= 0;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        jumpCounter = 0;
    }
}
