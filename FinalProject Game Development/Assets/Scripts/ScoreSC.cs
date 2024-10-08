using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSC : MonoBehaviour
{
    public static ScoreSC Instance { get; private set; } // Singleton instance

    [SerializeField] private TMP_Text _scoreText;
    private int _collisionCounter = 0;

    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this.gameObject); // Ensures that there isn't another instance
        }
        else
        {
            Instance = this;
        }
    }

    void Start()
    {
        _scoreText.text = "Score: " + _collisionCounter.ToString();
    }

    public void AddScore(int points)
    {
        _collisionCounter += points;
        _scoreText.text = "Score: " + _collisionCounter.ToString();
    }
}
