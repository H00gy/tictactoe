using UnityEngine;
using TMPro;

public class StatsPopup : MonoBehaviour
{
    [SerializeField] StatsDataManager statsManager;
    [Header("Stats Text Refs")]
    public TMP_Text TotalGames;
    public TMP_Text PlayerXWins;
    public TMP_Text PlayerOWins;
    public TMP_Text DrawCount;
    public TMP_Text AverageGameTime;

    public void loadStats()
    {
        statsManager.LoadData();
        TotalGames.text = "Total Games Played: " + StatsDataManager.TotalGames.ToString();
        PlayerXWins.text = "Player X Wins:" + StatsDataManager.PlayerXWins.ToString();
        PlayerOWins.text = "Player O Wins:" + StatsDataManager.PlayerOWins.ToString();
        DrawCount.text = "Total Game Draws: " + StatsDataManager.DrawCount.ToString();
        AverageGameTime.text = "Average Game Time: " + FormatTime(StatsDataManager.AverageMatchTime); 
    }
    string FormatTime(float time) //makes timer readable
    {
        int minutes = Mathf.FloorToInt(time / 60);
        int seconds = Mathf.FloorToInt(time % 60);
        return string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
