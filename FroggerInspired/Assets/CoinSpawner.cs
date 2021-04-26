using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public Coin coin;

    private void Start()
    {
        InvokeRepeating("spawnCoins", 0f, 5f);
    }

    void spawnCoins()
    {
        int randomIndex = Random.Range(0, spawnPoints.Length);
        Transform spawnPoint = spawnPoints[randomIndex];

        Instantiate(coin, spawnPoint.position, spawnPoint.rotation);
    }
}
