using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public GameObject player;
    private readonly float distanceFromPlayer = 6;
    private readonly float height = 5;
    private readonly float rotationAngle = 30;

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position - player.transform.forward * distanceFromPlayer;
        transform.LookAt(player.transform.position);
        transform.SetPositionAndRotation(new Vector3(0, transform.position.y + height, transform.position.z),
            Quaternion.Euler(rotationAngle, 0, 0));
    }
}