using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{

    // Declare Variables

    public float MoveSpeed = 50;
    public float MaxSpeed = 15;
    public float Drag = 0.98f;
    public float SteerAngle = 20;
    public float Traction = 1;

    private Vector3 MoveForce;

    // Update is called once per frame.
    private void FixedUpdate()
    {

        //This creates forwards and backwards movement.
        MoveForce += transform.forward * MoveSpeed * Input.GetAxis("Vertical") * Time.fixedDeltaTime;

        //This creates the steering in-game.
        float steerInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up * steerInput * MoveForce.magnitude * SteerAngle * Time.fixedDeltaTime);

        //This is the drag and max speed limit.
        MoveForce *= Drag;
        MoveForce = Vector3.ClampMagnitude(MoveForce, MaxSpeed);

        //This is for the traction in-game.
        Debug.DrawRay(transform.position, MoveForce.normalized * 3);
        Debug.DrawRay(transform.position, transform.forward * 3, Color.blue);
        MoveForce = Vector3.Lerp(MoveForce.normalized, transform.forward, Traction * Time.fixedDeltaTime) * MoveForce.magnitude;


        // Apply movement
        transform.position += MoveForce * Time.fixedDeltaTime;
    }

}
