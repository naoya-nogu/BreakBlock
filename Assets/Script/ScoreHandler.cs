using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreHandler {	

	// Singleton Class, Constructor should be private
	private static ScoreHandler _myInstance = new ScoreHandler();

	public static ScoreHandler GetInstance() {
		return _myInstance;
	}

	private int _score = 0;

	// Singleton Class, Constructor should be private
	private  ScoreHandler() {}

	// update private score field.
	public void UpdateScore(int score) {
		this._score = this._score + score;
	}

	// getter
	public int GetScore() {
		return this._score;
	}
}
	
