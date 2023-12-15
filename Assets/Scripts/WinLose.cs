using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinLose : MonoBehaviour
{
    private bool gameEnd;
    public void WinLevel()
    {
        if (!gameEnd)
        {
            gameEnd = true;
            Debug.Log("You Win!");
        }
    }
    public void LoseLevel()

    {
        if (!gameEnd)
        {
            gameEnd = true;
            Debug.Log("You Lose!");
        }
    }

}
