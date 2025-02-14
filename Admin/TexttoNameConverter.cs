using UnityEngine;
using TMPro;
using System.Collections;

public class DatabaseTextUpdater : MonoBehaviour
{
    public TextMeshProUGUI nameText; // Reference to the TextMeshPro UI element

    // Simulated database data (replace with actual database queries)
    private string[] names = { "Alice", "Bob", "Charlie", "Diana", "Eve" };
    private int currentIndex = 0;

    public float updateInterval = 2.0f; // Time interval between updates (in seconds)

    void Start()
    {
        // Initialize the text with the first name
        UpdateNameText();

        // Start a coroutine to update the text automatically
        StartCoroutine(AutoUpdateNames());
    }

    // Function to update the text with the next name
    void UpdateNameText()
    {
        if (names.Length > 0)
        {
            nameText.text = names[currentIndex];
            currentIndex = (currentIndex + 1) % names.Length; // Loop through the names
        }
        else
        {
            nameText.text = "No data available";
        }
    }

    // Coroutine to update names automatically
    IEnumerator AutoUpdateNames()
    {
        while (true) // Infinite loop
        {
            yield return new WaitForSeconds(updateInterval); // Wait for the specified interval
            UpdateNameText(); // Update the text
        }
    }
}