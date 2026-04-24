using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayUIManager : MonoBehaviour
{
    
    [Header("Popup References")]
    public GameObject ThemeSelect;
    public GameObject StatsPopup;
    public GameObject ExitPopup;
    [Header("Button Sound")]
    public AudioSource PrimaryButtonClickSound;
    public AudioSource SecondaryButtonClickSound;

    void Start()
    {
        ThemeSelect.SetActive(false);
        StatsPopup.SetActive(false);
        ExitPopup.SetActive(false);
    }

    // play Button Popup
    public void OpenThemeSelect()
    {
        PrimaryButtonClickSound.Play();
        ThemeSelect.SetActive(true);
    }
    public void CloseThemeSelect()
    {
        SecondaryButtonClickSound.Play();
        ThemeSelect.SetActive(false);
    }
    public void SelectTheme(int ThemeID)
    {
        SecondaryButtonClickSound.Play();
        PlayerTurn.StyleIndex = ThemeID;

    }
    public void LoadGameScene()
    {
        PrimaryButtonClickSound.Play();
        SceneManager.LoadScene(0);
    }

    // Stats Button Popup

    public void OpenStats()
    {
        PrimaryButtonClickSound.Play();
        StatsPopup.SetActive(true);
        StatsPopup.GetComponent<StatsPopup>().loadStats();
        
    }
    public void CloseStats()
    {
        SecondaryButtonClickSound.Play();
        StatsPopup.SetActive(false);
    }
    public void OpenExitPopup()
    {
        PrimaryButtonClickSound.Play();
        ExitPopup.SetActive(true);
    }
    public void CloseExitPopup()
    {
        SecondaryButtonClickSound.Play();
        ExitPopup.SetActive(false);
    }
    public void ExitGame()
    {
        Application.Quit();
    }

    
    
    
    

    
    
}
