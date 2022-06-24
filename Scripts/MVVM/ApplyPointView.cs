using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyPointView : MonoBehaviour
{
    [SerializeField] private int _score;
    private ScoreViewModel _scoreViewModel;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _scoreViewModel = collision.GetComponent<ScoreView>()._scoreViewModel;
        _scoreViewModel.ApplyPoint(_score);
        Destroy(gameObject);
    }
}
