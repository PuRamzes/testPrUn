using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

	public GameObject obj;
	public float speed = 5f, moveSpeed = 3f, turnSpeed = 40f;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		float horizontal = Input.GetAxis ("Horizontal");
		//float xPos = horizontal * speed;

		//obj.transform.position = new Vector3 (xPos, 0, 0);
		checks ();
	}

	void checks(){
		if(Input.GetKey(KeyCode.UpArrow)){
			obj.transform.Translate (Vector3.forward * moveSpeed * Time.deltaTime);
		}
		if(Input.GetKey(KeyCode.DownArrow)){
			obj.transform.Translate (-Vector3.forward * moveSpeed * Time.deltaTime);
		}
		if(Input.GetKey(KeyCode.LeftArrow)){
			obj.transform.Rotate (-Vector3.up * turnSpeed * Time.deltaTime);
		}
		if(Input.GetKey(KeyCode.RightArrow)){
			obj.transform.Rotate (Vector3.up * turnSpeed * Time.deltaTime);
		}
	}
		
}
