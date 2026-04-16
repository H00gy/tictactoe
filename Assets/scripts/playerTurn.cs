using System;
using UnityEngine;
using UnityEngine.UI;

public class playerTurn : MonoBehaviour
{
    public StyleGroup[] styleGroups;
    Button[] gridButtons;
    int buttonIndex;
    public int styleIndex;

    private void Awake()
    {
        gridButtons = GetComponentsInChildren<Button>();

        for(int i = 0; i < gridButtons.Length; i++)
        {
            buttonIndex = i;
            gridButtons[i].onClick.AddListener(() => buttonClick(buttonIndex));
            gridButtons[i].image.sprite = null;
        }

    }
    public void buttonClick(int index)
    {
        gridButtons[buttonIndex].image.sprite = styleGroups[styleIndex].X;
    }


    // debugging
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            styleIndex = 1;
            Debug.Log("index is 1");
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            styleIndex = 2;
            Debug.Log("index is 2");
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            styleIndex = 3;
            Debug.Log("index is 3");
        }
    }
}
