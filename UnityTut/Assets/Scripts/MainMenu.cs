using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void GoToScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void OuitApp()
    {
        Application.Quit();
        Debug.Log("Game has stopped");
    }
}
