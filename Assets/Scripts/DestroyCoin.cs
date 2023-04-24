using UnityEngine;

public class DestroyCoin : MonoBehaviour
{
    LogicScript logicScript;

    public GameObject coin;

    private void Start()
    {
        logicScript = GameObject.FindObjectOfType<LogicScript>();
    }

    private void OnTriggerExit(Collider other)
    {
        logicScript.IncrementScore(5);
        Destroy(coin);
    }
}
