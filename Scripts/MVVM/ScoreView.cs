using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

internal sealed  class ScoreView : MonoBehaviour
{
    [SerializeField] private Text _text;
    public ScoreViewModel _scoreViewModel;
    public CoinSpawnerController _coinSpawner;
    public PlayerController _playerController;

    public void Initialize(ScoreViewModel scoreViewModel, CoinSpawnerController coinSpawner)
    {
        _scoreViewModel = scoreViewModel;
        _coinSpawner = coinSpawner;
        _scoreViewModel.OnScoreChange += OnScoreChange;
        _scoreViewModel.OnGetDamage += OnGetDamage;
    }

    private void OnScoreChange(int currentScore)
    {
        _text.text = "Score: "+currentScore.ToString();
        if (_scoreViewModel.IsWin)
            SceneManager.LoadScene(1);
        _coinSpawner.SpawnCoin();
        MyTrigger.CreatePart = true;
    }

    private void OnGetDamage()
    {
        SceneManager.LoadScene(2);
    }

    private void OnDisable()
    {
        _scoreViewModel.OnScoreChange -= OnScoreChange;
    }
}
