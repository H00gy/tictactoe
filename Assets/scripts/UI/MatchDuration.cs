using UnityEngine;
using System.Collections;
using TMPro;

public class MatchDuration : MonoBehaviour
{
    [Header("References")]
    [SerializeField] OnGameEnd GameEnd;
    [SerializeField] PlayerSwitch Players;
    [Header("Timer UI")]
    [SerializeField] public TMP_Text timerText = null;

    [SerializeField] private float TimerSpeed = 1.0f;
    private float CurrentTime;
    
    private void Start()
    {
        CurrentTime = 0;
        UpdateTimerText();
        StartCoroutine(MatchTime(CurrentTime));
    }
    IEnumerator MatchTime(float time) // counts time up
    {
        while (!GameEnd.SomeoneWon)
        {
            yield return new WaitForSeconds(TimerSpeed);
            CurrentTime += TimerSpeed;

            UpdateTimerText();
        }


    }
    void UpdateTimerText() 
    {
        timerText.text = FormatTime(CurrentTime);
    }
    string FormatTime(float time) //makes timer readable
    {
        int minutes = Mathf.FloorToInt(time / 60);
        int seconds = Mathf.FloorToInt(time % 60);
        return string.Format("{0:00}:{1:00}", minutes, seconds);
    }
    
}
