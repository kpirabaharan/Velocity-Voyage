using UnityEngine;

public class GroundSpawner : MonoBehaviour
{
    public GameObject groudTile;
    public GameObject logObstacle;
    public GameObject treeObstacle;
    Vector3 nextSpawnPoint;
    Vector3 nextLogSpawnPoint;
    Vector3 nextTreeSpawnPoint;

    // Start is called before the first frame update
    private void Start()
    {
        int randomXLog;
        int randomXTree;
        if (Random.value < 0.5f)
            randomXLog = -1;
        else
            randomXLog = 1;
        if (Random.value < 0.5f)
            randomXTree = -2;
        else
            randomXTree = 2;
        nextLogSpawnPoint = new Vector3(randomXLog, 0, 20);
        nextTreeSpawnPoint = new Vector3(randomXTree, 0, 30);
        for (int i = 0; i < 10; i++)
        {
            SpawnTile();
            SpawnLog();
            SpawnTrees();
        }
    }

    public void SpawnTile()
    {
        GameObject tile = Instantiate(groudTile, nextSpawnPoint, Quaternion.identity);
        nextSpawnPoint = tile.transform.GetChild(1).transform.position;
    }

    public void SpawnLog()
    {
        int randomX;
        if (Random.value < 0.5f)
            randomX = -1;
        else
            randomX = 1;
        GameObject log = Instantiate(logObstacle, nextLogSpawnPoint, Quaternion.identity);
        nextLogSpawnPoint = new Vector3(randomX, 0, log.transform.position.z + 20);
    }

    public void SpawnTrees()
    {
        int randomX;
        if (Random.value < 0.5f)
            randomX = -2;
        else
            randomX = 2;
        GameObject tree = Instantiate(treeObstacle, nextTreeSpawnPoint, Quaternion.identity);
        nextTreeSpawnPoint = new Vector3(randomX, 0, tree.transform.position.z + 20);
    }
}
