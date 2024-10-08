using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ExitGame : MonoBehaviour
{
    public void Exit()
    {
        // If the game is being run in the Unity Editor, stop playing.
#if UNITY_EDITOR
        EditorApplication.isPlaying = false;
#else
        
        Application.Quit();
#endif
    }
}