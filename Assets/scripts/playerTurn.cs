using UnityEngine;
using UnityEngine.UI;

public class PlayerTurn : MonoBehaviour
{
    public StyleGroup[] StyleGroups;
    Button[] GridButtons;
    PlayerSwitch Players;

    public int StyleIndex;

    private void Awake()
    {
        // debugging
        StyleIndex = Random.Range(0, 2);

        // awake
        GridButtons = GetComponentsInChildren<Button>(); // finds all buttons
        Players = GetComponent<PlayerSwitch>();

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


    // debugging
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            StyleIndex = 0;
            Debug.Log("index is 1");
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            StyleIndex = 1;
            Debug.Log("index is 2");
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            StyleIndex = 2;
            Debug.Log("index is 3");
        }
    }
}
