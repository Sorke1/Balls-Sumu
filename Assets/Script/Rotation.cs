using UnityEngine;

public class SimpleRotation : MonoBehaviour
{
    public float rotationSpeed = 30f; // Speed of rotation in degrees per second

    // Update is called once per frame
    void Update()
    {
        // Rotate the object around the y-axis
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}
