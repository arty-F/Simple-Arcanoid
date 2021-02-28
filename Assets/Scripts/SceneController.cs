using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void OnClickStart()
    {
        SceneManager.LoadScene("Level");
    }

    public void OnClickExit()
    {
        Application.Quit();
    }

    public void OnGameWin()
    {
        SceneManager.LoadScene("StartMenu");
    }
}
