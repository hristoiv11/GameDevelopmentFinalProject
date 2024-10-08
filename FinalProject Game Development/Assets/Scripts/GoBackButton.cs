using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoBackButton : MonoBehaviour
{
    
    public void GoBackToSceneSelection(string sceneName)
    {
        SceneManager.LoadScene(sceneName); 
    }
}
