using UnityEngine;

public class SwordOrbit : MonoBehaviour
{
    public float rotationSpeed = 180f;

    private void Update()
    {
        transform.Rotate(0f, 0f, rotationSpeed * Time.deltaTime);
    }
}