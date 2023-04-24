using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject coin;
    Vector3 nextSpawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        nextSpawnPoint = new Vector3(0, 1, 25);
        SpawnFiveCoins();
    }

    void SpawnFiveCoins()
    {
        for (int i = 0; i < 5; i++)
        {
            GameObject spawnedCoin = Instantiate(coin, nextSpawnPoint, Quaternion.identity);
            nextSpawnPoint = spawnedCoin.transform.GetChild(1).transform.position;
        }
    }
}
