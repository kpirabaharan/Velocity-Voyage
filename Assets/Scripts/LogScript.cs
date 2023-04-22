using UnityEngine;

public class LogScript : MonoBehaviour
{
    PlayerMovement playerMovement;

    // Start is called before the first frame update
    void Start()
    {
        playerMovement = GameObject.FindObjectOfType<PlayerMovement>();
    }

    private void OnTriggerEnter(Collider other)
    {
        playerMovement.runSpeed = 0;
        Destroy(gameObject);
    }
}
