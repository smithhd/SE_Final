/*
 *  Hunter Smith
 *  Player class is used to get input to move character. based on keyboard input
 *  calls methods in character class
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{
    //represents the flag to be captured
    public int flag;

    //called when flag is picked up by player
    public void pickup()
    {
        flag++;
    }

    // called to start the start method in character class
    protected override void Start()
    {
        base.Start();
    }

    //called to update the position of the character in the game in character class
    protected override void Update()
    {
        getInput();

        base.Update();
    }

    //receives keyboard input from the player based on W, A, S, and D
    public void getInput()
    {
        direction = Vector2.zero; //reset the direction 

        if (Input.GetKey(KeyCode.W))
        {
            direction += Vector2.up;
        }
        if (Input.GetKey(KeyCode.A))
        {
            direction += Vector2.left;
        }
        if (Input.GetKey(KeyCode.S))
        {
            direction += Vector2.down;
        }
        if (Input.GetKey(KeyCode.D))
        {
            direction += Vector2.right;
        }
    }
}
