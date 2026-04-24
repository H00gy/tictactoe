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
    public static bool IsMusicOn;
    public static bool IsSFXOn;

    public void SaveData()
    {

        StatsData statsData = new StatsData();
        statsData.TotalGames = TotalGames;
        statsData.PlayerXWins = PlayerXWins;
        statsData.PlayerOWins = PlayerOWins;
        statsData.DrawCount = DrawCount;
        statsData.TotalMatchTime = TotalMatchTime;
        statsData.IsMusicOn = IsMusicOn;
        statsData.IsSFXOn= IsSFXOn;
        if (TotalGames> 0)
        {
            statsData.AverageMatchTime = TotalMatchTime / TotalGames;
        }
        else
        {
            TotalMatchTime= 0;
        }
        

        string json = JsonUtility.ToJson(statsData);
        string path = Application.persistentDataPath + "/statsData.json";
        System.IO.File.WriteAllText(path, json);
    }

    public void LoadData()
    {
        string path = Application.persistentDataPath + "/statsData.json";

        if (File.Exists(path))
        {
            string json = System.IO.File.ReadAllText(path); // went back to json because it would be better for a more realistic build because it cannot be 
            StatsData LoadedData = JsonUtility.FromJson<StatsData>(json);

            TotalGames = LoadedData.TotalGames;
            PlayerXWins = LoadedData.PlayerXWins;
            PlayerOWins = LoadedData.PlayerOWins;
            DrawCount = LoadedData.DrawCount;
            TotalMatchTime = LoadedData.TotalMatchTime;
            AverageMatchTime = LoadedData.AverageMatchTime;
            IsMusicOn= LoadedData.IsMusicOn;
            IsSFXOn= LoadedData.IsSFXOn;
        }

        else
        {
            Debug.LogWarning("statsData file not found");
        }

    }
    

}
