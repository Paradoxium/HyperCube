using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*PlayerMovement
 * Andrew Miller
 * 4/10/22
 * 
 * The PlayerMovement script is responsible for how the player  moves in the sceen.
 * The player moves foward at constant speed determined by the forwardSpeed variable.
 * The player moves side to side and up and down  by a speed determined by the speed variable.
 * 
 * The players x and y controlls can be disabled with the active boolean. This is used in
 * the menu scenes.
 * 
 * Attach this script to the player.
 */

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public float forwardSpeed;
    public bool active;
    
    // Update is called once per frame
    void Update()
    {
        transform.Translate(transform.forward*Time.deltaTime*forwardSpeed);
        if (active)
        {
            if (Input.GetKey("w") || Input.GetKey(KeyCode.UpArrow))
            {
                transform.Translate(transform.up * Time.deltaTime * speed);
            }
            if (Input.GetKey("s") || Input.GetKey(KeyCode.DownArrow))
            {
                transform.Translate(transform.up * Time.deltaTime * -speed);
            }
            if (Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Translate(transform.right * Time.deltaTime * -speed);
            }
            if (Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow))
            {
                transform.Translate(transform.right * Time.deltaTime * speed);
            }
        }
    }
}
