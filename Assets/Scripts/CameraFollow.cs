using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;

    private void LateUpdate()
    {
        if (player != null && player.gameObject.activeInHierarchy)
        {
            transform.position = new Vector3(
                player.position.x,
                player.position.y,
                transform.position.z
            );
        }
    }
}