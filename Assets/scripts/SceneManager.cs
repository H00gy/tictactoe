using UnityEngine;
using UnityEngine.SceneManagement; 

public class SceneController : MonoBehaviour
{
    public void LoadGame()
    {
        SceneManager.LoadScene(0);
    }
    public void LoadMenu()
    {
        SceneManager.LoadScene(1);
    }
}
