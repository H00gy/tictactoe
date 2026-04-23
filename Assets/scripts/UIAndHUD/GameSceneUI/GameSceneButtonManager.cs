using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSceneButtonManager : MonoBehaviour
{
    [SerializeField] SceneController sceneController;
    public AudioSource ButtonSound;
    
    public void Retry() // for retry button
    {
        ButtonSound.Play();
        sceneController.LoadGame();
    }
    public void ExitToMenu()
    {
        ButtonSound.Play();
        sceneController.LoadMenu();
    }
}
