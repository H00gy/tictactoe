using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    [SerializeField] SceneController sceneController;
    
    public void Retry() // for retry button
    {
        sceneController.ReloadCurrentLevel();
    }
    public void ExitToMenu()
    {
        sceneController.LoadMenu();
    }
}
