using UnityEngine.SceneManagement;
using UnityEngine;

public class GameOverPanel : MonoBehaviour
{
    public void QuitGame()
    {
        Application.Quit();
    }

    public void MainMenu()
    {
        SceneManager.LoadSceneAsync(0);
    }
}
