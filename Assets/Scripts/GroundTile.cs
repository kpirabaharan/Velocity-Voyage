using UnityEngine;

public class GroundTile : MonoBehaviour
{
    GroundSpawner groundSpawner;

    // Start is called before the first frame update
    void Start()
    {
        groundSpawner = GameObject.FindObjectOfType<GroundSpawner>();
    }

    private void OnTriggerExit(Collider collider)
    {
        groundSpawner.SpawnTile();
        groundSpawner.SpawnLog();
        Destroy(gameObject, 2);
    }
}
