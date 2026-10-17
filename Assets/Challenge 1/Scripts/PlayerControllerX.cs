using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public float speedChangeRate = 0.05f;
    public float minimumSpeed = 0.1f;
    public float maximumSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float pitchInput = Input.GetAxis("Vertical");
        float speedInput = Input.GetAxis("Horizontal");

        // Left slows the plane down and right speeds it up.
        speed -= speedInput * speedChangeRate;
        speed = Mathf.Clamp(speed, -maximumSpeed, -minimumSpeed);

        // Move the plane forward at its current speed.
        transform.Translate(Vector3.back * speed);

        // Pitch the plane based on the vertical input.
        transform.Rotate(Vector3.right * rotationSpeed * pitchInput);
    }
}
