using UnityEngine;
using UnityEngine.SceneManagement;

public class levelsMenu : MonoBehaviour
{
    public void lvl1()
    {
        SceneManager.LoadScene("niveau1");
    }
    public void lvl2()
    {
        SceneManager.LoadScene("niveau2");
    }
    public void lvl3()
    {
        SceneManager.LoadScene("niveau3");
    }
}

