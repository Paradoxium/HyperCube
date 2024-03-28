using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/* ResetPlayer
 * Andrew Miller 
 * 4/09/22
 * 
 * ResetPlayer restarts the scene using a string SceneName (enter in inspector).
 * 
 * OnCollisionEnter checks for the player's tag and will restart the scene using the SceneName
 * variable.
 * 
 * If there is no SceneName it will be set to the name of the current scene in the Start() function.
 * Attach this script to the finishline in the scene.
 */
public class ResetPlayer : MonoBehaviour
{
    public string SceneName;
    private void Start()
    {
        if(SceneName == "")
        {
            SceneName = SceneManager.GetActiveScene().name;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(SceneName);
        }
    }
}