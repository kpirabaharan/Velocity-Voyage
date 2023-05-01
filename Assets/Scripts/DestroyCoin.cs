using UnityEngine;

public class DestroyCoin : MonoBehaviour
{
    public GameObject coin;

    private void OnTriggerExit(Collider other)
    {
        Destroy(coin, 1);
    }
}
