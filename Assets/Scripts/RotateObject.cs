using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*RotateObject
 * Andrew Miller
 * 4/10/22
 * 
 * RotateObject will rotate a game object on a given axis at a set speed.
 * Axis and Speed are set in the inspector.
 * 
 * Attach this script to a gameobject like a pillar that will spin.
 */
public class RotateObject : MonoBehaviour
{
    public bool left;
    public bool right;
    public bool up;
    public bool down;

    public float speed;

    private void Update()
    {
        if (left)
        {
            Vector3 calculateAngle = new Vector3(0, 10f * speed * Time.deltaTime, 0);
            transform.Rotate(calculateAngle);
        }
        if (right)
        {
            Vector3 calculateAngle = new Vector3(0, -10f * speed * Time.deltaTime, 0);
            transform.Rotate(calculateAngle);
        }
        if (up)
        {
            Vector3 calculateAngle = new Vector3(0, 0, 10f * speed * Time.deltaTime);
            transform.Rotate(calculateAngle);
        }
        if (down)
        {
            Vector3 calculateAngle = new Vector3(0, 0, -10f * speed * Time.deltaTime);
            transform.Rotate(calculateAngle);
        }
    }
}
