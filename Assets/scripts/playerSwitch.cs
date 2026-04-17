using UnityEngine;
[System.Serializable]

public enum PlayerSymbol { X, O }
public class PlayerSwitch : MonoBehaviour
{
   
    public PlayerSymbol CurrentTurn;

    public void ToggleTurn()
    {
        // change logic
        CurrentTurn = (CurrentTurn == PlayerSymbol.X) ? PlayerSymbol.O : PlayerSymbol.X; 

    }
}
