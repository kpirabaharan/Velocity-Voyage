using UnityEngine;

public class DestroyCoin : MonoBehaviour
{
    CoinSpawner coinSpawner;

    public GameObject coin;

    private void Start()
    {
        coinSpawner = GameObject.FindObjectOfType<CoinSpawner>();
    }

    private void OnTriggerExit(Collider other)
    {
        coinSpawner.SetNextSpawnPoint(coin);
        coinSpawner.SpawnCoin();
        Destroy(coin, 1);
    }
}
