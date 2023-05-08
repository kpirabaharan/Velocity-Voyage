using UnityEngine;

public class TreeScript : MonoBehaviour
{
    PlayerMovement playerMovement;
    LogicScript logicScript;

    // Start is called before the first frame update
    void Start()
    {
        playerMovement = GameObject.FindObjectOfType<PlayerMovement>();
        logicScript = GameObject.FindObjectOfType<LogicScript>();
    }

    private void OnTriggerEnter(Collider other)
    {
        playerMovement.runSpeed = 0;
        logicScript.OnGameOver();
    }
}
