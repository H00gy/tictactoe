using UnityEngine;
using UnityEditor;


public class DeveloperTools 
{
    [MenuItem("Tools/Clear Stats Save")]
    public static void DeleteStats()
    {
        PlayerPrefs.DeleteAll();
        Debug.Log("--- All PlayerPrefs Deleted! ---");
    }
}
