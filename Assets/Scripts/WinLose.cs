using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinLose : MonoBehaviour
{
    private bool gameEnd;
    public void WinLevel()//this script triggers a text in the console that says you win when the conditions are met
    {
        if (!gameEnd)
        {
            gameEnd = true;
            Debug.Log("You Win!");
        }
    }
    public void LoseLevel()//this script is the same for when you lose

    {
        if (!gameEnd)
        {
            gameEnd = true;
            Debug.Log("You Lose!");
        }
    }

}
