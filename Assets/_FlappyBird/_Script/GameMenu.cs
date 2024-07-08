using GameTool;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameMenu : SingletonUI<GameMenu>
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highestSoreText;

    public void UpdateSoreText(int newScore)
    {
        scoreText.text = "Score: " + newScore;
    }
    public void UpdateHighestSoreText(int newScore)
    {
        highestSoreText.text = "Highest Score: " + newScore;
    }
    public void Start()
    {
        highestSoreText.text = "Highest Score: " + GameData.Instance.HighestScore;
    }
}
