using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    [SerializeField] private GameObject Coin;
    [SerializeField] private Transform[] Positions;
    [SerializeField] private int ScoreToWin;
    void Start()
    {
        var coinSpawner = new CoinSpawnerController(Coin, Positions);
        var scoreModel = new ScoreModel(ScoreToWin);
        var scoreViewModel = new ScoreViewModel(scoreModel);
        FindObjectOfType<ScoreView>().Initialize(scoreViewModel, coinSpawner);
    }

}
