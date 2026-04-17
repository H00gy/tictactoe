using UnityEngine;
using UnityEngine.UI;
public class GameStart : MonoBehaviour
{
    public Button[] GridButtons;
    [SerializeField] PlayerTurn PlayerTurns;
    private void Awake()
    {
        // awake
        GridButtons = GetComponentsInChildren<Button>(); // finds all buttons


        for (int i = 0; i < GridButtons.Length; i++)
        {
            int buttonIndex = i;
            GridButtons[i].onClick.AddListener(() => PlayerTurns.OnButtonClick(buttonIndex)); // so I don't manually assign clicks
            GridButtons[i].image.sprite = null;
        }
    }
    
}
