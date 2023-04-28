using UnityEngine;

public class CollectCoin : MonoBehaviour
{
    LogicScript logicScript;
    CoinSpawner coinSpawner;

    public GameObject coin;

    private void Start()
    {
        logicScript = GameObject.FindObjectOfType<LogicScript>();
        coinSpawner = GameObject.FindObjectOfType<CoinSpawner>();
    }

    private void OnTriggerExit(Collider other)
    {
        coinSpawner.SetNextSpawnPoint(coin);
        coinSpawner.SpawnCoin();
        logicScript.IncrementScore(5);
        Destroy(coin);
    }
}
