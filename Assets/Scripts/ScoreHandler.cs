using System;
using UnityEngine;
using UnityEngine.UI;

public class ScoreHandler: MonoBehaviour
{
    [SerializeField] private PlayerScore _playerScore;
    [SerializeField] private Text _scoreText;

    private void Start()
    {
        _playerScore.score = 0;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        AddPoint();
        UpdateScoreText();
        
        if(_playerScore.score == 5)
            StopGame();
    }

    private void StopGame()
    {
        Time.timeScale = 0;
    }

    private void AddPoint()
    {
        _playerScore.score++;
    }

    private void UpdateScoreText()
    {
        _scoreText.text = _playerScore.score.ToString();
    }
}