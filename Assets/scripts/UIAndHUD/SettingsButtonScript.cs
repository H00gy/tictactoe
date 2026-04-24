using UnityEngine;
using UnityEngine.UI;

public class SettingsButtonScript : MonoBehaviour
{
    [Header("Popup Reference")]
    public GameObject SettingsPopup;
    [Header("Sound References")]
    public AudioSource Music;
    public GameObject SFXGameobject;
    public AudioSource PrimaryButtonClickSound;
    public AudioSource SecondaryButtonClickSound;
    [Header("UI Toggles")]
    public Toggle MusicToggle;
    public Toggle SFXToggle;

    private void Awake()
    {
        GetComponent<StatsDataManager>().LoadData();
    }
    private void Start()
    {
        SettingsPopup.SetActive(false);
        if (MusicToggle != null) MusicToggle.isOn = StatsDataManager.IsMusicOn;
        if (SFXToggle != null) SFXToggle.isOn = StatsDataManager.IsSFXOn;
    }
    public void OpenSettings()
    {
        PrimaryButtonClickSound.Play();
        SettingsPopup.SetActive(true);
    }
    public void CloseSettings()
    {
        SecondaryButtonClickSound.Play();
        SettingsPopup.SetActive(false);
    }
    public void ToggleMusic(bool isMusicOn)
    {
        if (isMusicOn)
        {
            StatsDataManager.IsMusicOn = true;
            Music.Play();
        }
        else
        {
            StatsDataManager.IsMusicOn = false;
            Music.Stop();
        }
        
    }
    
    public void ToggleSFX(bool isSFXOn)
    {
        if (isSFXOn)
        {
            foreach (Transform Sound in SFXGameobject.transform)
            {
                StatsDataManager.IsSFXOn = true;
                Sound.GetComponent<AudioSource>().volume = 1;
            }
        }
        else
        {
            foreach (Transform Sound in SFXGameobject.transform)
            {
                StatsDataManager.IsSFXOn = false;
                Sound.GetComponent<AudioSource>().volume = 0;
            }
        }
        
        
    }
    
}
