using UnityEngine;
using UnityEngine.SceneManagement;

public class Intro : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene( "MainWindow" );
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
