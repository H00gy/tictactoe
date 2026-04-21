using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MovesCounter : MonoBehaviour
{
    [Header("References")]
    public Image CounterImageStyle;
    public TMP_Text PlayerMoves;
    public int MovesCount;

    private void Start()
    {
        PlayerMoves.text = "Move " + 0.ToString();
        MovesCount= 0;
    }
    public void CountMoves()
    {
        
        MovesCount++;
        PlayerMoves.text = "Move " + MovesCount.ToString();
    }
    public void SetImageStyle(Sprite style)
    {
        CounterImageStyle.sprite = style;
    }
}
