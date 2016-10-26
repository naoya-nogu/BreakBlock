using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {
	public float speed = 1.0f;
	private int myScore = 1;

	// Use this for initialization
	void Start () {
		

	}
	
	// Update is called once per frame
	void Update () {
		transform.position -= new Vector3(0, 0, speed);
		if(this.transform.position.z < -17) {
			Application.LoadLevel("GameOver");
		}
	
	}

	void OnCollisionEnter(Collision collision){
		if (collision.gameObject.tag == "Player") {
			ScoreHandler sh = ScoreHandler.GetInstance ();
			sh.UpdateScore (this.myScore);
			Destroy (gameObject);
		}	

	}
}
