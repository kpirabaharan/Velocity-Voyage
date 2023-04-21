using UnityEngine;

public class GroundSpawner : MonoBehaviour
{
    public GameObject groudTile;
    Vector3 nextSpawnPoint;

    // Start is called before the first frame update
    private void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            SpawnTile();
        }
    }

    public void SpawnTile()
    {
        GameObject temp = Instantiate(groudTile, nextSpawnPoint, Quaternion.identity);
        nextSpawnPoint = temp.transform.GetChild(1).transform.position;
    }
}
