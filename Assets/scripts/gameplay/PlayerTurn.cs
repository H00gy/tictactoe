using UnityEngine;
using UnityEngine.UI;

public class PlayerTurn : MonoBehaviour
{
    [Header("References")]
    [SerializeField] GridScript Grid;
    [SerializeField] PlayerSwitch Players;
    [SerializeField] OnGameEnd GameEndState;
    [SerializeField] MovesCounter XMoves;
    [SerializeField] MovesCounter OMoves;
    [Header("XO Styles")]
    public StyleGroup[] StyleGroups; 
    int GridButtonCount = 1;
    public static int StyleIndex;
    [Header("SFX")]
    public AudioSource XSound;
    public AudioSource OSound;


    private void Awake()
    {
        // debugging

        //StyleIndex = Random.Range(0, 2);
        XMoves.SetImageStyle(StyleGroups[StyleIndex].X);
        OMoves.SetImageStyle(StyleGroups[StyleIndex].O);


    }
    public void OnButtonClick(int index)
    {
        
        if (Grid.GridButtons[index].image.sprite != null) { return; } // already taken

        
        
        if (Players.CurrentTurn == PlayerSymbol.X) // assign style
        {
            XSound.Play();
            Grid.GridButtons[index].image.sprite = StyleGroups[StyleIndex].X;
            XMoves.CountMoves();
            GameEndState.WinState();
        }
        else
        {
            OSound.Play();
            Grid.GridButtons[index].image.sprite = StyleGroups[StyleIndex].O;
            OMoves.CountMoves();
            GameEndState.WinState();
        }

        GridButtonCount++;

        if (GridButtonCount > Grid.GridButtons.Length && !GameEndState.SomeoneWon) { GameEndState.DrawState(); } 

        Players.ToggleTurn(); // change turn, last so it doesn't determine the wrong winning player
    }


   
}
