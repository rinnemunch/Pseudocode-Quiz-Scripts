using UnityEngine;
using TMPro;

public class Example5 : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI timerText;
    private float timeLeft = 5f;
    private bool isTimerActive = true;

    void Start()
    {
        // Pseudocode:
        // Update the score display to start with
        UpdateTimerText();
    }

    void Update()
    {
        // Pseudocode:
        // If the timer is active
        if (isTimerActive)
        {
            timeLeft -= Time.deltaTime;

            if (timeLeft <= 0)
            {
                timeLeft = 0;
                EndGame(); // Pseudocode: End the game when time reaches zero
            }

            // Pseudocode:
            // Update the timer display
            UpdateTimerText();
        }
    }

    private void UpdateTimerText()
    {
        // Pseudocode:
        // Display the time in seconds
        timerText.text = "Time Left: " + Mathf.Ceil(timeLeft).ToString();
    }

    private void EndGame()
    {
        isTimerActive = false;
        // Pseudocode:
        // Display "Game Over!" when time runs out
        timerText.text = "Game Over!";
    }
}
