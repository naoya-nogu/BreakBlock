using UnityEngine;
using System.Collections;

public class EnemyboxScript : MonoBehaviour {
	public GameObject Enemy;
	public float timeleft;
	// Update is called once per frame
	void Update () {
		float x = Random.Range(-9.5f, 9.5f);
		timeleft -= Time.deltaTime;
		if (timeleft <= 0.0) {
			Instantiate(Enemy, new Vector3(x, 1, 20), Quaternion.identity);
			timeleft = 1.0f;
		}

	}
}
