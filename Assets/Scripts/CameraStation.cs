using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraStation : MonoBehaviour
{
    [SerializeField] private Transform player;//declare the players position so that the camera can track it later
    //serialized field lets us edit the function in engine if the function is private
   
    void Update()
    {
        transform.position = new Vector3(player.position.x, player.position.y, transform.position.z); //create a vector 3 that tracks the players position and set the camera to be equal to it
    }
}
