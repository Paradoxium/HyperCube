using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*BackgroundMusic
 * Andrew Miller
 * 4/11/22
 * 
 * BackgroundMusic creates a persistant game object between scenes using the
 * singleton design pattern. 
 * 
 * Tag the background music gameobject with the tag "music".
 * Attach this script to the a the gameobject that plays music. 
 */
public class BackgroundMusic : MonoBehaviour
{
    private void Awake()
    {
        GameObject[] music = GameObject.FindGameObjectsWithTag("Music");
        if ( music.Length > 1)
        {
            Destroy(this.gameObject);
        } 
        else
        {
            DontDestroyOnLoad(this.gameObject);
        }
    }
}