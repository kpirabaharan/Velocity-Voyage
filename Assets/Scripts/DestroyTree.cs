using UnityEngine;

public class DestroyTree : MonoBehaviour
{
    public GameObject treeObstacle;

    private void OnTriggerExit(Collider other)
    {
        Destroy(treeObstacle, 2);
    }
}
