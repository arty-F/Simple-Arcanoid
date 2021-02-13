using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void OnClickStart()
    {
        SceneManager.LoadScene("Level", LoadSceneMode.Single);
    }

    public void OnClickExit()
    {
        Application.Quit();
    }
}
