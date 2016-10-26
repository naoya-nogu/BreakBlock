using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {
	
	private ScoreHandler sh = ScoreHandler.GetInstance ();

	// Use this for initialization
	void Start () {}
	
	// Update is called once per frame
	void Update () {		
		this.GetComponent<Text> ().text = "SCORE:" + this.sh.GetScore();
	}
}
	