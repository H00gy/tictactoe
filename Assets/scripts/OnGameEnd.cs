using UnityEngine;

public class OnGameEnd : MonoBehaviour
{
    [SerializeField] PlayerTurn PlayerTurns;
    
    public void WhenGameEnd()
    {
        Debug.Log("called game end ");
    }
    public void WinState()
    {
        // UI stuff here

        
    }
}
