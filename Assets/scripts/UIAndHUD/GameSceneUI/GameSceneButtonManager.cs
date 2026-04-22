using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSceneButtonManager : MonoBehaviour
{
    [SerializeField] SceneController sceneController;
    
    public void Retry() // for retry button
    {
        sceneController.LoadGame();
    }
    public void ExitToMenu()
    {
        sceneController.LoadMenu();
    }
}
