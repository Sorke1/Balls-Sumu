using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    public float speed = 100;

    // Update is called once per frame
    void Update()
    {
        // Check if the "Horizontal" button is pressed
        if (Input.GetButton("Horizontal"))
        {
            // Get the input value and rotate the camera accordingly
            float horizontalInput = Input.GetAxis("Horizontal");
            transform.Rotate(Vector3.up, horizontalInput * speed * Time.deltaTime);
        }
    }
}
