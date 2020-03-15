﻿using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public Text score;
    public Text highScore;

    public static int scoreValue = 0; //значение текущего рекорда
    public static int highScoreValue = 0; //значение наивысшего рекорда

    private float pointsPerSecond = 1; //скорость обновления рекорда 
    public static bool scoreIncreasing = true;
    

    void Start()
    {
        if (PlayerPrefs.HasKey("HighScore"))
        {
            highScoreValue = PlayerPrefs.GetInt("HighScore");
        }
        StartCoroutine(Score());
    }
    
    void Update()
    {
        if (scoreValue > highScoreValue)
        {
            highScoreValue = scoreValue;
            PlayerPrefs.SetInt("HighScore", highScoreValue);
        }

        score.text = "" + scoreValue;
        highScore.text = "" + highScoreValue;
    }
    
    public int SetScoreForOther(int scoreVal)
    {
        return scoreVal;
    }

    IEnumerator Score()
    {
        yield return new WaitForSeconds(2f);
        while (scoreIncreasing)
        {
            yield return new WaitForSeconds(pointsPerSecond);
            scoreValue += 1;
            SetScoreForOther(scoreValue);
        }
    }
}
