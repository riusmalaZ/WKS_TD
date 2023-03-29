using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseMenu : MonoBehaviour
{
    public void goMain()
    {
        SceneManager.LoadScene("main menu");
    }
}
