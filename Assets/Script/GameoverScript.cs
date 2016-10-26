using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameOverScript : MonoBehaviour {

	private ScoreHandler _sh = ScoreHandler.GetInstance ();

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		int score = _sh.GetScore ();
		this.GetComponent<Text> ().text = "GAME OVER\nSCORE:" + score;
	}
}
