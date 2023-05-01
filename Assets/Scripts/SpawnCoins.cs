using UnityEngine;

public class SpawnCoins : MonoBehaviour
{
    CoinSpawner coinSpawner;
    public GameObject coin;

    private void Start()
    {
        coinSpawner = GameObject.FindObjectOfType<CoinSpawner>();
    }

    private void OnTriggerExit(Collider other)
    {
        coinSpawner.SpawnCoin();
        Destroy(coin, 1);
    }
}
