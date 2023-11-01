using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private int _currentScore = 0;
    void Start()
    {
        GameEventManager.current.onTargetHit += IncrementScore;
		GameEventManager.current.onResetGame += ResetScore;
    }

    public void IncrementScore()
    {
        _currentScore += 1;
		Debug.Log("Current score: " + _currentScore.ToString());
        GameEventManager.current.UpdateText(_currentScore.ToString());
    }

	public void ResetScore()
	{
		_currentScore = 0;
		GameEventManager.current.UpdateText(_currentScore.ToString());
	}
}
