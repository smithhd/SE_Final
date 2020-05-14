//Hunter Smith
//checkend class checks to see if the player has returned the flag to the starting position. also, sends a message in the debug console when won.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class checkEnd : MonoBehaviour
{
    bool gameEnded = false;

    public float restartDelay = 1f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Player player = collision.GetComponent<Player>();

        if (player && player.flag == 1)
        {
            if (gameEnded == false)
            {
                gameEnded = true;
                FindObjectOfType<GameManager>().EndGame();
            }
        }
    }
}
