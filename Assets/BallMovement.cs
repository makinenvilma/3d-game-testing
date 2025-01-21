using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float speed = 5f; // Speed of the ball
    public float jumpPower = 5f; // Power of the jump
    private Rigidbody rb;

    void Start()
    {
        // Get the ball
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Movement
        float movementX = Input.GetAxis("Horizontal"); // Left and right
        float movementZ = Input.GetAxis("Vertical"); // Up and down

        // Moving the ball
        Vector3 movement = new Vector3(movementX, 0, movementZ) * speed;
        rb.AddForce(movement);

        // Jumping
        if (Input.GetKeyDown(KeyCode.Space)) // Välilyönti
        {
            Vector3 jump = new Vector3(0, jumpPower, 0);
            rb.AddForce(jump, ForceMode.Impulse);
        }
    }
}
