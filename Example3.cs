using UnityEngine;

public class Example3: MonoBehaviour
{
    [SerializeField] private Light _sceneLight;
    private bool _playerIsNear = false; // Tracks if player is near the button

    void Update()
    {
        // If player is near the button and presses E, toggle the light on/off
        if (_playerIsNear && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("E Pressed - Toggling Light!");

            // Toggle the light on/off
            _sceneLight.enabled = !_sceneLight.enabled;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        // If player enters the trigger area, allow interaction
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player Entered Trigger Zone");
            _playerIsNear = true; // Enable interaction with button
        }
    }

    private void OnTriggerExit(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player Exited Trigger Zone");
            _playerIsNear = false; // Disable interaction with button
        }
    }
}
