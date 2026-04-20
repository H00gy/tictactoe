using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class StrikeLine : MonoBehaviour
{
    public Image Line;
    public float Duration;
    public float ElapsedTime;

    public void Start()
    {
        Line.fillAmount = 1;
    }
    public void GenerateStrikeAnimation(Vector2 StartPos, Vector2 EndPos)
    {
        
        Line.transform.position = StartPos;
        Line.transform.rotation = Quaternion.LookRotation(EndPos); // rotates towards end pos
        Line.fillAmount = Mathf.Lerp(0,1, ElapsedTime / Duration);

    }
}
