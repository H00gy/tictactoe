using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;

public class OnGameEnd : MonoBehaviour
{
    [Header("References")]
    //[SerializeField] GameStart Grid;
    [SerializeField] PlayerTurn PlayerTurns;
    [SerializeField] PlayerSwitch Players;
    [SerializeField] StrikeLine Strike;
    [SerializeField] StatsDataManager statsDataManager;
    [Header("GameOverPopup References")]
    [SerializeField] GameObject GameOverPopup;
    [SerializeField] MatchDuration MatchTimer;
    public TMP_Text FinalMatchDuration;
    public TMP_Text MatchWinner;
    [Header("Winning Patterns")]
     public WinningPatternsGroup[] WinningCombinations;
    int TileCount;
    [Header("Other Variables")]
    public bool SomeoneWon = false;
    public float EndGamePopupWait;

    


    private void Start()
    {
        GameOverPopup.SetActive(false);

    }
    public void DrawState()
    {
        StartCoroutine(DisplayDraw()); 
    }
    public void WinState()
    {

        foreach (var group in WinningCombinations) // looks through all tile win combo groups
        {
            Button B1 = group.WinningPatterns[0];
            Button B2 = group.WinningPatterns[1];  
            Button B3 = group.WinningPatterns[2];
            Image StrikeLine = group.StrikeLine;

            if (B1.image.sprite == null) // no win possible
            {
                continue; 
            }
            if (B1.image.sprite == B2.image.sprite && B2.image.sprite == B3.image.sprite) // win condition
            {
                
                if (Players.CurrentTurn == PlayerSymbol.X) // who wins
                {                   
                    Strike.GenerateStrikeAnimation(StrikeLine);
                    StartCoroutine(DisplayWinner(Players.CurrentTurn));
                    return;
                }
                else
                {                   
                    Strike.GenerateStrikeAnimation(StrikeLine);
                    StartCoroutine(DisplayWinner(Players.CurrentTurn));
                    return;
                }
            }
        }

    }
    IEnumerator DisplayWinner(PlayerSymbol winner)
    {
        statsDataManager.SaveData();
        StatsDataManager.TotalGames++;
        Debug.Log("winner is " + winner);  //temp
        SomeoneWon = true;
        yield return new WaitForSeconds(EndGamePopupWait);
        GameOverPopup.SetActive(true);
        FinalMatchDuration.text = "Match Duration " + MatchTimer.timerText.text;
        MatchWinner.text = "The winner is " + winner;


    }
    IEnumerator DisplayDraw()
    {
        statsDataManager.SaveData();
        StatsDataManager.TotalGames++;
        StatsDataManager.DrawCount++;
        yield return new WaitForSeconds(EndGamePopupWait);
        GameOverPopup.SetActive(true);
        FinalMatchDuration.text = "Match Duration " + MatchTimer.timerText.text;
        MatchWinner.text = "Draw";
    }
   

    
}
