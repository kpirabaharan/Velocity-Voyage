using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject coins;
    Vector3 nextSpawnPoint;

    // Start is called before the first frame update
    private void Start()
    {
        int randomX = Random.Range(0, 3);

        int[] xValues = new int[] { -2, 0, 2 };

        int xPosition = xValues[randomX];

        nextSpawnPoint = new Vector3(xPosition, 1, 22);

        for (int i = 0; i < 10; i++)
        {
            SpawnCoin();
        }
    }

    public void SpawnCoin()
    {
        GameObject spawnedCoin = Instantiate(coins, nextSpawnPoint, Quaternion.identity);

        int randomX = Random.Range(0, 3);

        int[] xValues = new int[] { -2, 0, 2 };

        int xPosition = xValues[randomX];

        nextSpawnPoint = new Vector3(xPosition, 1, spawnedCoin.transform.position.z + 10);
    }
}
