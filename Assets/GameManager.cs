using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // This method should be called when the "Play" button is clicked
    public void ChangeScene()
    {
        // Change "GameScene" to the name of the scene you want to load
        SceneManager.LoadScene("MainScene");
    }

    // This method should be called when the "Quit" button is clicked
    public void QuitGame()
    {
        // Logs the quit request in the console (helpful for debugging in the editor)
        Debug.Log("Quit requested");

        // Quits the application
        Application.Quit();

        // If running in the Unity editor, this line will stop the editor's play mode
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}
