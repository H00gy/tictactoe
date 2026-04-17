using UnityEngine;
using UnityEngine.UI;

public class OnGameEnd : MonoBehaviour
{
    [Header("References")]
    [SerializeField] GameStart Grid;
    [SerializeField] PlayerTurn PlayerTurns;
    [SerializeField] PlayerSwitch Players;
    [Header("Winning Patters")]
     public WinningPatternsGroup[] WinningCombinations;
    int TileCount;
    public void WhenGameEnd()
    {
        Debug.Log("draw ");
    }
    public void WinState()
    {

        foreach (var group in WinningCombinations) // looks through all tile win combo groups
        {
            Button B1 = group.WinningPatterns[0];
            Button B2 = group.WinningPatterns[1];  
            Button B3 = group.WinningPatterns[2];

            if (B1.image.sprite == null) // no win possible
            {
                continue; 
            }
            if (B1.image.sprite == B2.image.sprite && B2.image.sprite == B3.image.sprite) // win condition
            {
                
                if (Players.CurrentTurn == PlayerSymbol.X) // who wins
                {
                    Debug.Log("winner is " + Players.CurrentTurn);
                }
                else
                {
                    Debug.Log("winner is " + Players.CurrentTurn);
                }
            }
        }

    }
    
}
