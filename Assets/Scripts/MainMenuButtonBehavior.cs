using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuButtonBehavior : MonoBehaviour
{
    public void ContinueButton()
    {

    }
    public void QuitButton()
    {
        // If running in the editor, stop playing the scene
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #else
        // If running in a build, quit the application
        Application.Quit();
        #endif
    }

}
