using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject logObstacle;
    public GameObject treeObstacle;
    Vector3 nextLogSpawnPoint;
    Vector3 nextTreeSpawnPoint;
    Vector3 nextLogTreeSpawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        int randomXLog;
        int randomXLogTree;
        int randomXTree = Random.Range(0, 3);

        if (Random.value < 0.5f)
        {
            randomXLog = -1;
            randomXLogTree = 2;
        }
        else
        {
            randomXLog = 1;
            randomXLogTree = -2;
        }

        int[] xValues = new int[] { -2, 0, 2 };

        int xPosition = xValues[randomXTree];

        nextLogSpawnPoint = new Vector3(randomXLog, 0, 20);
        nextTreeSpawnPoint = new Vector3(xPosition, 0, 30);
        nextLogTreeSpawnPoint = new Vector3(randomXLogTree, 0, 20);

        for (int i = 0; i < 10; i++)
        {
            SpawnLog();
            SpawnTree();
        }
    }

    public void SpawnLog()
    {
        int randomX;
        int otherRandomX;

        if (Random.value < 0.5f)
        {
            randomX = -1;
            otherRandomX = 2;
        }
        else
        {
            randomX = 1;
            otherRandomX = -2;
        }

        GameObject log = Instantiate(logObstacle, nextLogSpawnPoint, Quaternion.identity);
        nextLogSpawnPoint = new Vector3(randomX, 0, log.transform.position.z + 20);

        if (Random.value < 0.5f)
        {
            GameObject tree = Instantiate(treeObstacle, nextLogTreeSpawnPoint, Quaternion.identity);
        }

        nextLogTreeSpawnPoint = new Vector3(otherRandomX, 0, log.transform.position.z + 20);
    }

    public void SpawnTree()
    {
        for(int i = 0; i < 2; i++)
        { 
            int randomX = Random.Range(0, 3);

            int[] xValues = new int[] { -2, 0, 2 };

            int xPosition = xValues[randomX];

            GameObject tree = Instantiate(treeObstacle, nextTreeSpawnPoint, Quaternion.identity);
            nextTreeSpawnPoint = new Vector3(xPosition, 0, tree.transform.position.z + 10);
        }
    }
}
