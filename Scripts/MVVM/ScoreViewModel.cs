using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

internal sealed class ScoreViewModel
{
    private bool _isWin;
    public event Action<int> OnScoreChange;
    public event Action OnGetDamage;
    public ScoreModel ScoreModel { get; }
    public bool IsWin => _isWin;

    public ScoreViewModel(ScoreModel scoreModel)
    {
        ScoreModel = scoreModel;
    }

    public void ApplyPoint(int score)
    {
        ScoreModel.CurrentScore += score;
        if (ScoreModel.CurrentScore >= ScoreModel.MaxScore)
            _isWin = true;
        OnScoreChange?.Invoke(ScoreModel.CurrentScore);
    }

    public void GetDamage()
    {
        OnGetDamage?.Invoke();
    }
}
