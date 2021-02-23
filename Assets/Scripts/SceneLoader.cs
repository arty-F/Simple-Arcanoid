using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void OnClickStart()
    {
        SceneManager.LoadScene("Level");
    }

    public void OnClickExit()
    {
        Application.Quit();
    }
}
