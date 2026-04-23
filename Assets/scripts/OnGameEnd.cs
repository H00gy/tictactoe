using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;

public class OnGameEnd : MonoBehaviour
{
    [Header("References")]
    [SerializeField] GridScript Grid;
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
    public AudioSource StrikeLineSound;
    


    private void Start()
    {
        GameOverPopup.SetActive(false);

    }
    public void DrawState()
    {
        Grid.DisableButtons();
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
                    StrikeLineSound.Play();
                    Strike.GenerateStrikeAnimation(StrikeLine);
                    StartCoroutine(DisplayWinner(Players.CurrentTurn));
                    Grid.DisableButtons();
                    StatsDataManager.PlayerXWins++;
                    return;
                }
                else
                {
                    StrikeLineSound.Play();
                    Strike.GenerateStrikeAnimation(StrikeLine);
                    StartCoroutine(DisplayWinner(Players.CurrentTurn));
                    Grid.DisableButtons();
                    StatsDataManager.PlayerOWins++;
                    return;
                }
            }
        }

    }
    IEnumerator DisplayWinner(PlayerSymbol winner)
    {

        StatsDataManager.TotalGames++;
        SomeoneWon = true;
        yield return new WaitForSeconds(EndGamePopupWait);
        GameOverPopup.SetActive(true);
        FinalMatchDuration.text = "Match Duration " + MatchTimer.timerText.text;
        MatchWinner.text = "The winner is " + winner;
        statsDataManager.SaveData();


    }
    IEnumerator DisplayDraw()
    {

        StatsDataManager.TotalGames++;
        StatsDataManager.DrawCount++;
        yield return new WaitForSeconds(EndGamePopupWait);
        GameOverPopup.SetActive(true);
        FinalMatchDuration.text = "Match Duration " + MatchTimer.timerText.text;
        MatchWinner.text = "Draw";
        statsDataManager.SaveData();
    }
   

    
}
