using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
  //  [SerializeField] private GameObject optionsBox;

    private void Start()
    {
        Time.timeScale = 1.0f;
   //     optionsBox.SetActive(false);
    }
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void PlayWithComputer()
    {
        SceneManager.LoadScene(2);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
