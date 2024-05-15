using UnityEngine;
using UnityEngine.SceneManagement;

public class Control : MonoBehaviour
{
    public void Exitgame()
    {
        Application.Quit();
    }
    
    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
}
