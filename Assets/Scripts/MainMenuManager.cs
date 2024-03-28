using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*MainMenuManager
 * Andrew Miller
 * 4/09/22
 * 
 * MainMenuManager activates and de-activates UI panels.
 * Put this script on the Canvas in a scene, then tag each panel so this script can refrence it
 * in the Awake() function.
 * 
 * Make sure all panels are ACTIVE in the scene at the start of the game. Everything but the MainPanel
 * will deactivate when the Awake() function is called.
 * 
 * Attach this script to the Canvas game object in the scene.
 */


public class MainMenuManager : MonoBehaviour
{
    GameObject credits;
    GameObject mainPanel;
    GameObject levelSelectPanel;
    GameObject controlPanel;
    public AudioSource ClickIn; //assign in inspector
    public AudioSource ClickOut; 

    public void Awake()
    {
        credits = GameObject.FindGameObjectWithTag("Credits"); //tag panel in scene
        mainPanel = GameObject.FindGameObjectWithTag("MainPanel");
        levelSelectPanel = GameObject.FindGameObjectWithTag("LevelSelect");
        controlPanel = GameObject.FindGameObjectWithTag("ControlOption");

        controlPanel.SetActive(false);
        credits.SetActive(false);
        levelSelectPanel.SetActive(false);
    }

    /*
     * OPEN FUNCTIONS
     */
    public void OpenCreditsPanel()
    {
        mainPanel.SetActive(false);
        credits.SetActive(true);
        ClickIn.Play();
    }

    public void OpenLevelSelectPanel()
    {
        mainPanel.SetActive(false);
        levelSelectPanel.SetActive(true);
        ClickIn.Play();
    }

    public void OpenControlPanel()
    {
        mainPanel.SetActive(false);
        controlPanel.SetActive(true);
        ClickIn.Play();
    }

    /*
     * Close Functions
     */
    public void CloseCreditsPanel()
    {
        credits.SetActive(false);
        mainPanel.SetActive(true);
        ClickOut.Play();
    }

    public void CloseLevelSelect()
    {
        levelSelectPanel.SetActive(false);
        mainPanel.SetActive(true);
        ClickOut.Play();
    }

    public void CloseControlPanel()
    {
        controlPanel.SetActive(false);
        mainPanel.SetActive(true);
        ClickOut.Play();
    }
}
