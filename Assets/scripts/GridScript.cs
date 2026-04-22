using UnityEngine;
using UnityEngine.UI;

public class GridScript : MonoBehaviour
{
    [Header("References")]
    [SerializeField] PlayerTurn PlayerTurns;
    public Button[] GridButtons;

    private void Awake()
    {
        // awake
        GridButtons = GetComponentsInChildren<Button>(); // finds all buttons

        for (int i = 0; i < GridButtons.Length; i++)
        {
            int buttonIndex = i;
            GridButtons[i].interactable = true;
            GridButtons[i].onClick.AddListener(() => PlayerTurns.OnButtonClick(buttonIndex)); // so I don't manually assign clicks
            GridButtons[i].image.sprite = null;
        }
    }
    public void DisableButtons()
    {
        for (int i = 0; i < GridButtons.Length; i++)
        {
            GridButtons[i].interactable= false; // so players can't cheat and quickly hit a button before the strike animation finishes playing
        }
    }


}
