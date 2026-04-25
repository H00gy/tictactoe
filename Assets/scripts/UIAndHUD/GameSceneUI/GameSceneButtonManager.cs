using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSceneButtonManager : MonoBehaviour
{
    public AudioSource ButtonSound;
    
    public void Retry() // for retry button
    {
        ButtonSound.Play();
        SceneManager.LoadScene(1);
    }
    public void ExitToMenu()
    {
        ButtonSound.Play();
        SceneManager.LoadScene(0);
    }
}
