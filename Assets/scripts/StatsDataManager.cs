using UnityEngine;
using System.IO;

public class StatsDataManager : MonoBehaviour
{
    [Header("Saved Variables")]
    public static int TotalGames;
    public static int PlayerXWins;
    public static int PlayerOWins;
    public static int DrawCount;
    public static float TotalMatchTime;
    public static float AverageMatchTime;


    public void SaveData()
    {
        
        AverageMatchTime = TotalMatchTime / TotalGames;

        // Save each variable to a unique "Key"
        PlayerPrefs.SetInt("TotalGames", TotalGames);
        PlayerPrefs.SetInt("PlayerXWins", PlayerXWins);
        PlayerPrefs.SetInt("PlayerOWins", PlayerOWins);
        PlayerPrefs.SetInt("DrawCount", DrawCount);
        PlayerPrefs.SetFloat("TotalMatchTime", TotalMatchTime);
        PlayerPrefs.SetFloat("AverageMatchTime", AverageMatchTime);

        // Forces Unity to write the data to disk immediately
        PlayerPrefs.Save();

    }
    public void LoadData()
    {
        // Get data using the keys. The second number (0) is the default if no save exists.
        TotalGames = PlayerPrefs.GetInt("TotalGames", 0);
        PlayerXWins = PlayerPrefs.GetInt("PlayerXWins", 0);
        PlayerOWins = PlayerPrefs.GetInt("PlayerOWins", 0);
        DrawCount = PlayerPrefs.GetInt("DrawCount", 0);
        TotalMatchTime = PlayerPrefs.GetFloat("TotalMatchTime", 0f);
        AverageMatchTime = PlayerPrefs.GetFloat("AverageMatchTime", 0f);

        Debug.Log("Stats loaded via PlayerPrefs!");
    }
}
