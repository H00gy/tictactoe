using UnityEngine;
using UnityEditor;
using System.IO;


public class DeveloperTools 
{
    // This creates the menu item at the top of Unity
    [MenuItem("Tools/Wipe JSON Save File")]
    public static void DeleteSaveFile()
    {
        // We calculate the path exactly the same way the Manager does
        string path = Path.Combine(Application.persistentDataPath, "statsData.json");

        if (File.Exists(path))
        {
            File.Delete(path);

            // so the game feels reset immediately without restarting Unity.
            StatsDataManager.TotalGames = 0;
            StatsDataManager.PlayerXWins = 0;
            StatsDataManager.PlayerOWins = 0;
            StatsDataManager.DrawCount = 0;
            StatsDataManager.TotalMatchTime = 0;
            StatsDataManager.AverageMatchTime = 0;
            StatsDataManager.IsMusicOn = true;
            StatsDataManager.IsSFXOn= true;

            Debug.Log("<color=green>--- JSON Save File Deleted and Memory Reset! ---</color>");
        }
        else
        {
            Debug.Log("<color=yellow>--- No Save File Found at: " + path + " ---</color>");
        }
    }

    [MenuItem("Tools/Open Save Folder")]
    public static void OpenSaveFolder()
    {
        // This opens the actual Windows/Mac folder so you can see the JSON file
        EditorUtility.RevealInFinder(Application.persistentDataPath);
    }
}
