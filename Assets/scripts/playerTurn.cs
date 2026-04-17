using UnityEngine;
using UnityEngine.UI;

public class PlayerTurn : MonoBehaviour
{
    [Header("References")]
    [SerializeField] GameStart Grid;
    [SerializeField] PlayerSwitch Players;
    [SerializeField] OnGameEnd GameEndState;
    [Header("XO Styles")]
    public StyleGroup[] StyleGroups; 
    int GridButtonCount = 1;
    public int StyleIndex;

    private void Awake()
    {
        // debugging

        StyleIndex = Random.Range(0, 2);

    }
    public void OnButtonClick(int index)
    {
        
        if (Grid.GridButtons[index].image.sprite != null) { return; } // already taken

        
        
        if (Players.CurrentTurn == PlayerSymbol.X) // assign style
        {
            Grid.GridButtons[index].image.sprite = StyleGroups[StyleIndex].X;
            GameEndState.WinState(Grid.GridButtons[index]);
        }
        else
        {
            Grid.GridButtons[index].image.sprite = StyleGroups[StyleIndex].O;
            GameEndState.WinState(Grid.GridButtons[index]);
        }

        GridButtonCount++;

        if (GridButtonCount > Grid.GridButtons.Length) { GameEndState.WhenGameEnd(); } // draws will rewrite

        Players.ToggleTurn(); // change turn
    }


   
}
