using UnityEngine;

public class CollectSpawnCoins : MonoBehaviour
{
    CoinSpawner coinSpawner;
    LogicScript logicScript;

    public GameObject coin;

    private void Start()
    {
        coinSpawner = GameObject.FindObjectOfType<CoinSpawner>();
        logicScript = GameObject.FindObjectOfType<LogicScript>();
    }

    private void OnTriggerExit(Collider other)
    {
        logicScript.IncrementScore(5);
        coinSpawner.SpawnCoin();
        Destroy(coin);
    }
}
