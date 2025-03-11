using UnityEngine;

public class Example1 : MonoBehaviour
{
    [SerializeField] private float _jumpForce = 7f; // Adjust jump height to your liking!
    private Rigidbody _rb;
    private bool _isGrounded;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Pseudocode:
        // When the player presses space  
        // The character jumps  

        // If spacebar is pressed and player is grounded, apply jump force
        if (Input.GetKeyDown(KeyCode.Space) && _isGrounded)
        {
            _rb.AddForce(Vector3.up * _jumpForce, ForceMode.Impulse);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        // Check if player is touching the ground
        if (collision.gameObject.CompareTag("Ground")) //make sure to add Ground tag to your ground object
        {
            _isGrounded = true;
        }
    }

    void OnCollisionExit(Collision collision)
    {
        // Player is in the air
        if (collision.gameObject.CompareTag("Ground"))
        {
            _isGrounded = false;
        }
    }
}
