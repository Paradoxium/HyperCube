using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*MainMenuReset
 * Andrew Miller
 * 4/09/22
 * 
 * MainMenuReset puts the player  back to their original position in the scene
 * rather than reloading the scene completely.
 * 
 * This script is used for the Menu Scenes. 
 * Put this on the finishline in the scene.
 */

public class MainMenuReset : MonoBehaviour
{
    GameObject player;
    Vector3 playerStart; 
    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerStart = player.GetComponent<Transform>().position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            player.transform.position = playerStart;
        }
    }
}
