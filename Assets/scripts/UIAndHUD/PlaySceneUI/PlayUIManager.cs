using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayUIManager : MonoBehaviour
{
    [Header("Script References")]
    [Header("Popup References")]
    public GameObject ThemeSelect;
    public GameObject StatsPopup;

    void Start()
    {
        ThemeSelect.SetActive(false);
        StatsPopup.SetActive(false);
    }

    // play Button Popup
    public void OpenThemeSelect()
    {
        ThemeSelect.SetActive(true);
    }
    public void CloseThemeSelect()
    {
        ThemeSelect.SetActive(false);
    }
    public void SelectTheme(int ThemeID)
    {
        PlayerTurn.StyleIndex = ThemeID;

    }
    public void LoadGameScene()
    {
        SceneManager.LoadScene(0);
    }

    // Stats Button Popup

    public void OpenStats()
    {
       
        StatsPopup.SetActive(true);
        StatsPopup.GetComponent<StatsPopup>().loadStats();
        
    }
    public void CloseStats()
    {
        StatsPopup.SetActive(false);
    }

    
    
    
    

    
    
}
