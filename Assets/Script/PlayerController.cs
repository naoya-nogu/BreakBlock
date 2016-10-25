using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed = 10.0f;
	public float shorten_speed = 0.3f;
	public float size = 5.0f;
	// Use this for initialization
	void Start () {}
	
	// Update is called once per frame
	void Update () {

		float horizontal_move = Input.GetAxis ("Horizontal") * speed;
		transform.Translate (horizontal_move, 0, 0);

//		if (Input.GetMouseButtonDown(0)) {
//
//			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
//			RaycastHit hit = new RaycastHit();
//
//			if (Physics.Raycast(ray, out hit)){
//				GameObject obj = hit.collider.gameObject;
//				Debug.Log(obj.name);
//			}
//		}
	
	}

	void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.name == "Enemy(Clone)" && size > 1.0f) {
			transform.localScale -= new Vector3(shorten_speed, 0, 0);
			size -= shorten_speed;
		
		}

	}



}
