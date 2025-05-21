using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoSingleton<UIManager>
{
    [SerializeField]
    TMP_Text _basketballText;
    int _basketballScore = 0;

    private void Start()
    {
        _basketballText.text = _basketballScore.ToString("00");
    }

    public void AddBasketballScore(int points)
    {
        _basketballScore += points;
        _basketballText.text = _basketballScore.ToString("00");
    }
}
