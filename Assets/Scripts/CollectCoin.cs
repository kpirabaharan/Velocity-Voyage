using UnityEngine;

public class CollectCoin : MonoBehaviour
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
