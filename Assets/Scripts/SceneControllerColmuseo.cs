using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControllerColmuseo : MonoBehaviour
{
    public void ChangeScene()
    {
        SceneManager.LoadScene("Colmuseo");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
