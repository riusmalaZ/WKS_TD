using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("niveau1");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
