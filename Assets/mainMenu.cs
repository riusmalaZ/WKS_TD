using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("levels");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
