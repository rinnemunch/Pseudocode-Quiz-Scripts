using UnityEngine;
using TMPro;  // Include this for TextMeshPro manipulation

public class Example4 : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText; // Reference to the TextMeshPro component
    private int score = 0; // Player's score

    void Start()
    {
        // Pseudocode:
        // Update the score display to start with
        UpdateScoreText();
    }

    // This method will be called when the player collects the coin
    private void OnTriggerEnter(Collider other)
    {
        // Pseudocode:
        // If the player collects a coin
        if (other.CompareTag("Coin")) // Check if the player collides with the coin
        {
            // Pseudocode:
            // Increase the score by 1
            score++;

            // Pseudocode:
            // Update the score display
            UpdateScoreText();

            // Pseudocode:
            // Destroy the coin
            Destroy(other.gameObject);
        }
    }

    // Update the score text in the UI
    private void UpdateScoreText()
    {
        // Pseudocode:
        // Display score in the format "Score: X"
        scoreText.text = "Score: " + score;
    }
}
