using System.Collections;
using System.Collections.Generic;
using UnityEngine;

internal sealed class ScoreModel
{
    public int MaxScore { get; }
    public int CurrentScore;

    public ScoreModel(int maxScore)
    {
        MaxScore = maxScore;
        CurrentScore = 0;
    }
}
