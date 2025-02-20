using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private int _score;

    public void UpdateScore()
    {
        _score++;
        scoreText.text = _score.ToString();
    }
}
