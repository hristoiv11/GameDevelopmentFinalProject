using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsScript : MonoBehaviour
{
    
    [SerializeField] private GameObject _pauseButton;
    [SerializeField] private GameObject _resumeButton;
    [SerializeField] private GameObject _pauseMenu;
    [SerializeField] private GameObject _resumeMenu;

    private GameObject _uiManager;
    private int count = 0;
    void Start()
    {
        _pauseButton.SetActive(true);
        _resumeButton.SetActive(false);

    }

    public void OnPause()
    {

        Time.timeScale = 0.0f;
        _pauseMenu.SetActive(true);
        _resumeButton.SetActive(true);
        _pauseButton.SetActive(false);

    }

    public void OnResume()
    {
        Time.timeScale = 1.0f;
        _resumeMenu.SetActive(true);
        _pauseButton.SetActive(true);
        _resumeButton.SetActive(false);

    }

    public void OnReload()
    {
        SceneManager.LoadScene(SceneManager
            .GetActiveScene().name);
    }

    private void OnCollisionEnter(Collision collision)
    {
        count = count + 1;
    }

}
