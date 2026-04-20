using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using DG.Tweening;
public class StrikeLine : MonoBehaviour
{
    public GameObject StrikeLineManager;
    public float Duration;
    public AudioSource Whoosh;

    public void Start()
    {
        Image[] AllLines = StrikeLineManager.GetComponentsInChildren<Image>(); // clears all strike lines
        foreach (Image img in AllLines)
        {
            img.fillAmount= 0;
        } 
    }
    public void GenerateStrikeAnimation(Image StrikeLine)
    {
        StrikeLine.DOFillAmount(1f, Duration); // animated strikeline
        Whoosh.Play();
    }
}
