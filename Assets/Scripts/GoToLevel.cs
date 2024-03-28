using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*GoToLevel
 *Andrew Miller
 *4/09/22
 *
 * GoToLevel changes the scene to a new scene.
 * Call the changeLevel function using a button and enter the name of the new scene.
 * 
 * Attach to the Canvas gameobject in the scene and then use with a button in the scene.
 */
public class GoToLevel : MonoBehaviour
{
    public void changeLevel(string nextLevel)
    {
        SceneManager.LoadScene(nextLevel);
    }
}