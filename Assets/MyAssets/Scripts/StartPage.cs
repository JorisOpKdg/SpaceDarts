using UnityEngine;
using UnityEngine.SceneManagement;

// Starts the menu scene
public class StartPage : MonoBehaviour
{
    public void StartMenuScene()
    {
        SceneManager.LoadScene("MenuScene");
        Debug.Log("MenuScene started...");
    }
}
