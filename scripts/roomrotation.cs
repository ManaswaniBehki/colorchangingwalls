using UnityEngine;

public class roomrotation : MonoBehaviour
{
    public float rotationSpeed = -1.0f;

    void Update()
    {
        // Rotate the room around the Y-axis at a constant speed.
        transform.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);
    }
}
