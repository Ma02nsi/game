using UnityEngine;

public class GameExit : MonoBehaviour
{
    void Update()
    {
        // Check if the player presses the Escape key
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            QuitGame();
        }
    }

    // Function to quit the game
    void QuitGame()
    {
        // Quit the game (close the application)
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; // This stops the game in the Unity Editor
        #else
        Application.Quit(); // This quits the game when running as a standalone application
        #endif
    }
}
