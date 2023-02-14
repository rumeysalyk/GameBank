using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroductionScreen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void ToMainScreen()
    {
        SceneManager.LoadScene( "GameScene" );
    }
}
