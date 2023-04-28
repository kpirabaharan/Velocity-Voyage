using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject coin;
    Vector3 nextSpawnPoint;

    // Start is called before the first frame update
    private void Start()
    {
        nextSpawnPoint = new Vector3(0, 1, 23);
        for (int i = 0; i < 9; i++)
        {
            SpawnFiveCoins();
        }
    }

    public void SpawnFiveCoins()
    {
        for (int i = 0; i < 5; i++)
        {
            int randomX = Random.Range(0, 3);
            GameObject spawnedCoin = Instantiate(coin, nextSpawnPoint, Quaternion.identity);
            if (i == 4)
            {
                nextSpawnPoint = new Vector3(0, 1, spawnedCoin.transform.position.z + 16);
                continue;
            }
            nextSpawnPoint = new Vector3(0, 1, spawnedCoin.transform.position.z + 1);
        }
    }

    public void SpawnCoin()
    {
        GameObject spawnedCoin = Instantiate(coin, nextSpawnPoint, Quaternion.identity);
    }

    public void SetNextSpawnPoint(GameObject coin)
    {
        nextSpawnPoint = new Vector3(0, 1, coin.transform.position.z + 180);
    }
}
