using UnityEngine;
using UnityEngine.SceneManagement;

// Starts the game scenes
public class NewExpeditionManager : MonoBehaviour
{
    public void StartMoonExpedition() 
    {
        SceneManager.LoadScene("LaunchMoonScene");
        StateManager.Instance.MissionName = "Moon";
        Debug.Log("LaunchMoonScene started...");
    }

    public void StartMarsExpedition()
    {
        SceneManager.LoadScene("LaunchMarsScene");
        StateManager.Instance.MissionName = "Mars";
        Debug.Log("LaunchMarsScene started...");
    }

    public void StartJupiterExpedition()
    {
        SceneManager.LoadScene("LaunchJupiterScene");
        StateManager.Instance.MissionName = "Jupiter";
        Debug.Log("LaunchJupiterScene started...");
    }
}
