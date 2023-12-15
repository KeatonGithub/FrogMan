using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTriggers : MonoBehaviour
{
    public WinLose winLoseScript;
    void Update()
    {
      if(transform.position.y < -12.0f)//when the player falls off trigger the lose level script
        {
            winLoseScript.LoseLevel();//trigger the loselevel script
        }

      if(transform.position.x > 16.5f)//when the player hits the x coordinate at the end of the level they win
        {
            winLoseScript.WinLevel();//trigger the winlevel script
        }
    }
}
