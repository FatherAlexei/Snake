using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawnerController : MonoBehaviour
{
    private GameObject Coin;
    private Transform[] Positions;
    public CoinSpawnerController(GameObject coin, Transform[] positions)
    {
        Coin = coin;
        Positions = positions;
        SpawnCoin();
    }
    public void SpawnCoin()
    {
        Instantiate(Coin, Positions[Random.Range(0, Positions.Length)].position, Quaternion.identity);
    }
}
