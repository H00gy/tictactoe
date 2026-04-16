using UnityEngine;
using UnityEngine.UI;

public class playerTurn : MonoBehaviour
{
    public StyleGroup[] styleGroups;
    Button[] gridButtons;
    playerSwitch players;

    public int styleIndex;

    private void Awake()
    {
        // debugging
        styleIndex = Random.Range(0, 2);

        // awake
        gridButtons = GetComponentsInChildren<Button>(); // finds all buttons
        players = GetComponent<playerSwitch>();

        for(int i = 0; i < gridButtons.Length; i++) 
        {
            int buttonIndex = i;
            gridButtons[i].onClick.AddListener(() => buttonClick(buttonIndex)); // so I don't manually assign clicks
            gridButtons[i].image.sprite = null;
        }

    }
    public void buttonClick(int index)
    {
        if (gridButtons[index].image.sprite != null) { return; } // already taken
        
        if (players.player == true)
        {
            gridButtons[index].image.sprite = styleGroups[styleIndex].X;
        }
        else
        {
            gridButtons[index].image.sprite = styleGroups[styleIndex].O;
        }
        players.playerChange();
        
    }


    // debugging
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            styleIndex = 0;
            Debug.Log("index is 1");
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            styleIndex = 1;
            Debug.Log("index is 2");
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            styleIndex = 2;
            Debug.Log("index is 3");
        }
    }
}
