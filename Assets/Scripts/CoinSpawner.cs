using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject coin;
    Vector3 nextSpawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        nextSpawnPoint = new Vector3(0, 1, 22);
        SpawnFiveCoins();
    }

    void SpawnFiveCoins()
    {
        for (int i = 0; i < 5; i++)
        {
            int randomX = Random.Range(0, 3);
            GameObject spawnedCoin = Instantiate(coin, nextSpawnPoint, Quaternion.identity);
            if (i == 4)
            {
                nextSpawnPoint = new Vector3(randomX, 0, spawnedCoin.transform.position.z + 50);
                continue;
            }
            nextSpawnPoint = spawnedCoin.transform.GetChild(1).transform.position;
        }
    }
}
