using UnityEngine;

public class GroundTile : MonoBehaviour
{
    GroundSpawner groundSpawner;
    ObstacleSpawner obstacleSpawner;

    // Start is called before the first frame update
    void Start()
    {
        groundSpawner = GameObject.FindObjectOfType<GroundSpawner>();
        obstacleSpawner = GameObject.FindObjectOfType<ObstacleSpawner>();
    }

    private void OnTriggerExit(Collider collider)
    {
        groundSpawner.SpawnTile();
        obstacleSpawner.SpawnLog();
        obstacleSpawner.SpawnTree();
        Destroy(gameObject, 2);
    }
}
