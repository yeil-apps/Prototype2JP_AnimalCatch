using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int _lives = 3;
    private int _score = 0;
    public void AddLives(int value)
    {
        _lives += value;
        if (_lives <= 0)
        {
            Debug.Log("GameOver");
            _lives = 0;
        }
        Debug.Log("Lives = " + _lives);
    }


    public void AddScore(int value)
    {
        _score += value;
        Debug.Log("Score = " + _score);
    }
}
