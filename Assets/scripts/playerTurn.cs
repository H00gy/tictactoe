using UnityEngine;
using UnityEngine.UI;

public class PlayerTurn : MonoBehaviour
{
    public StyleGroup[] StyleGroups;
    Button[] GridButtons;
    [SerializeField] PlayerSwitch Players;

    public int StyleIndex;

    private void Awake()
    {
        // debugging
        StyleIndex = Random.Range(0, 2);

        // awake
        GridButtons = GetComponentsInChildren<Button>(); // finds all buttons
        

        for(int i = 0; i < GridButtons.Length; i++) 
        {
            int buttonIndex = i;
            GridButtons[i].onClick.AddListener(() => OnButtonClick(buttonIndex)); // so I don't manually assign clicks
            GridButtons[i].image.sprite = null;
        }

    }
    public void OnButtonClick(int index)
    {
        if (GridButtons[index].image.sprite != null) { return; } // already taken

        
        if (Players.CurrentTurn == PlayerSymbol.X)
        {
            GridButtons[index].image.sprite = StyleGroups[StyleIndex].X;
        }
        else
        {
            GridButtons[index].image.sprite = StyleGroups[StyleIndex].O;
        }
        
        Players.ToggleTurn();
        
    }


   
}
