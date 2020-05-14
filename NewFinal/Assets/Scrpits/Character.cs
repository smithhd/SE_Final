/*
 *  Hunter Smith
 *  Character class moves the character on the game screen and animates the character 
 *
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    //speed of player to move, serialized to show in inspector
    [SerializeField]
    private float speed; 

    //animator for character
    private Animator animator;

    //direction the player is moving
    protected Vector2 direction; 

    //gives the character a rigid body in game
    private Rigidbody2D myRigidBody;

    // called to assign the character a rigid body and animate its movement
    protected virtual void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    protected virtual void Update()
    {
    }

    //calls move function
    private void FixedUpdate()
    {
        Move();
    }

    //moves character in given direction, as well as different animations
    public void Move()
    {
        myRigidBody.velocity = direction.normalized * speed;
        AnimateMove(direction);
    }

    //animates the movement of the character based off direction
    //param: direction is the direction the player is moving to decide animation
    public void AnimateMove(Vector2 direction)
    {
        animator.SetFloat("x", direction.x);
        animator.SetFloat("y", direction.y);
    }
}
