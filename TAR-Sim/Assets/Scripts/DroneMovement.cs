using UnityEngine;
using UnityEngine.InputSystem;

public class DroneMovement : MonoBehaviour
{
    Rigidbody ourDrone;
    public float upForce;
    private PlayerInput droneInput;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ourDrone = GetComponent<Rigidbody>();
        droneInput = GetComponent<PlayerInput>();


    }

    void FixedUpdate()
    {


        VerticalMovement();
        ourDrone.AddRelativeForce(Vector3.up * upForce);
    }
    void VerticalMovement()
    {



    }

    // Update is called once per frame
    void Update()
    {
        // Vector2 move = droneInput.getAct
    }
}
