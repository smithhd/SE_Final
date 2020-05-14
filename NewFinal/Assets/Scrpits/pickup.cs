//Hunter Smith
//pickup class checks if the player has reached the flag and destroys the game object
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Player player = collision.GetComponent<Player>();

        if (player)
        {
            player.pickup();
            Destroy(gameObject);
        }
    }

}
