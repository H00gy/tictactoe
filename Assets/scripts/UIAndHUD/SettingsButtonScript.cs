using UnityEngine;
using UnityEngine.UI;

public class SettingsButtonScript : MonoBehaviour
{
    [Header("Popup Reference")]
    public GameObject SettingsPopup;
    [Header("Sound References")]
    public AudioSource Music;
    public GameObject SFX;


    private void Start()
    {
        SettingsPopup.SetActive(false);
    }
    public void OpenSettings()
    {
        SettingsPopup.SetActive(true);
    }
    public void CloseSettings()
    {
        SettingsPopup.SetActive(false);
    }
    public void ToggleMusic(bool isMusicOn)
    {
        if (isMusicOn)
        {
            Music.Play();
        }
        else
        {
            Music.Stop();
        }
        
    }
    
    public void ToggleSFX(bool isSFXOn)
    {
        if (isSFXOn)
        {
            foreach (Transform Sound in SFX.transform)
            {
                Sound.GetComponent<AudioSource>().volume = 1;
            }
        }
        else
        {
            foreach (Transform Sound in SFX.transform)
            {
                Sound.GetComponent<AudioSource>().volume = 0;
            }
        }
        
        
    }
    
}
