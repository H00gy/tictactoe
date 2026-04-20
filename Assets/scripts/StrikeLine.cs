using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class StrikeLine : MonoBehaviour
{
    public GameObject StrikeLineManager;
    public float Duration;
    public float ElapsedTime;

    public void Start()
    {
        Image[] AllLines = StrikeLineManager.GetComponentsInChildren<Image>();
        foreach (Image img in AllLines)
        {
            img.fillAmount= 0;
        }
           
        
        
    }
    public void GenerateStrikeAnimation(Vector2 StartPos, Vector2 EndPos)
    {
        
        
       
        StrikeLineManager.GetComponentInChildren<Image>().fillAmount = Mathf.Lerp(0,1, ElapsedTime / Duration);

    }
}
