using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{

    public int P1Score;
    public int P2Score;
    public int P3Score;
    public int P4Score;

    public int maxScore;
    public Ball ball;

    public void AddP1Score(int increment)
    {
        P1Score += increment;
        ball.ResetBall();

        if (P1Score >= maxScore)
            GameOver();
    }

    public void AddP2Score(int increment)
    {
        P2Score += increment;
        ball.ResetBall();

        if(P2Score >= maxScore)
        {
            GameOver();
        }
    }

    public void AddP3Score(int increment)
    {
        P2Score += increment;
        ball.ResetBall();

        if (P3Score >= maxScore)
        {
            GameOver();
        }
    }

    public void AddP4Score(int increment)
    {
        P2Score += increment;
        ball.ResetBall();

        if (P4Score >= maxScore)
        {
            GameOver();
        }
    }

    public void GameOver()
    {
        SceneManager.LoadScene("Game Over");
    }

}
