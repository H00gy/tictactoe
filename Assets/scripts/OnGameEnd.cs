using UnityEngine;

public class OnGameEnd : MonoBehaviour
{
    [SerializeField] PlayerTurn PlayerTurns;
    [SerializeField] PlayerSwitch Players;
    
    public void WhenGameEnd()
    {
        Debug.Log("called game end ");
    }
    public void WinState()
    {
        



    }
}
