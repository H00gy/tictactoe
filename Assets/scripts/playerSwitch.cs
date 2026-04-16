using UnityEngine;

public class playerSwitch : MonoBehaviour
{
    public Sprite[] XOs;
    SpriteRenderer sr;

    private void Awake()
    {
        sr = GetComponent<SpriteRenderer>();

    }
}
