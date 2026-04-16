using UnityEngine;

public class playerTurn : MonoBehaviour
{
    public Sprite[] XOs;
    SpriteRenderer sr;

    private void Awake()
    {
        sr = GetComponent<SpriteRenderer>();

    }
    public void onClick()
    {

    }
}
