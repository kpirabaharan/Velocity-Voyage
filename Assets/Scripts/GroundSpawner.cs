using UnityEngine;

public class GroundSpawner : MonoBehaviour
{
    public GameObject groudTile;
    public GameObject logObstacle;
    Vector3 nextSpawnPoint;
    Vector3 nextLogSpawnPoint;

    // Start is called before the first frame update
    private void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            SpawnTile();
            SpawnLog();
        }
    }

    public void SpawnTile()
    {
        GameObject temp = Instantiate(groudTile, nextSpawnPoint, Quaternion.identity);
        nextSpawnPoint = temp.transform.GetChild(1).transform.position;
    }

    public void SpawnLog()
    {
        GameObject tempTree = Instantiate(logObstacle, nextLogSpawnPoint, Quaternion.identity);
        nextLogSpawnPoint = new Vector3(0, 0, tempTree.transform.position.z + 20);
    }
}
