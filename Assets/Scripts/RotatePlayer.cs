using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*RotatePlayer
 * Andrew Miller
 * 4/09/22
 * 
 * RotatePlayer rotates the player at a speed set by the speed variable in the inspector.
 * 
 * This script is used on the menu scenes to rotate the player.
 * Attach this script to the player.
 */
public class RotatePlayer : MonoBehaviour
{
    public float speed;

    private void Update()
    {
        Vector3 calculateAngle = new Vector3(0, 0, 10f * speed * Time.deltaTime);
        transform.Rotate(calculateAngle);
    }
    
}
