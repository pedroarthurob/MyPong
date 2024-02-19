using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
  //  [SerializeField] private GameObject optionsBox;

    private void Start()
    {
   //     optionsBox.SetActive(false);
    }
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync(1);
    }


    public void QuitGame()
    {
        Application.Quit();
    }
}
