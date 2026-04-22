using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayUIManager : MonoBehaviour
{
    [Header("Popup References")]
    public GameObject ThemeSelect;

    void Start()
    {
        ThemeSelect.SetActive(false);
    }
    public void LoadGameScene()
    {
        SceneManager.LoadScene(0);
    }
    public void CloseThemeSelect()
    {
        ThemeSelect.SetActive(false);
    }
    public void OpenThemeSelect()
    {
        ThemeSelect.SetActive(true);
    }
    public void SelectTheme(int ThemeID)
    {
        PlayerTurn.StyleIndex = ThemeID;

    }
    

    
    
}
