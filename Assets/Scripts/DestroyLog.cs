using UnityEngine;

public class DestroyLog : MonoBehaviour
{
    public GameObject logObstacle;

    private void OnTriggerExit(Collider other)
    {
        Destroy(logObstacle, 2);
    }
}
