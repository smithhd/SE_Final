//Hunter Smith
//GameManager class holds the functions to be called to display win/loss in the debug console
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
     public void EndGame()
    {
        Debug.Log("YOU WON");
    }

    public void EndLose()
    {
        Debug.Log("YOU LOSE");
    }
}
