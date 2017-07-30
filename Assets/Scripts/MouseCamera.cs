using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCamera : MonoBehaviour {

	private float horizontalSpeed = 1.0f;
	private float verticalSpeed  = 1.0f;

	private float glassfish;

	// Use this for initialization
	void Start () {
		glassfish = transform.position.z;
	}
	
	// Update is called once per frame
	void Update () {
		/*
		if (Input.GetButton ("Fire1")) {
			print ("yes");
		}
		*/
		if (Input.GetKey (KeyCode.Mouse1)) {
			float h = horizontalSpeed * Input.GetAxis ("Mouse Y");
			float v = verticalSpeed * Input.GetAxis ("Mouse X");
			transform.Translate (v, h, 1.7f);
			print (h);
		} else {
			transform.position.Set (transform.position.x,
				transform.position.y,glassfish);
		}


		if (Input.GetKey (KeyCode.A)) {
			float x = 0.01f;
			float y = 0;
			float z = 0.01f;
			transform.Translate (z,y , z);
		}

		//print (Input.GetButton(KeyCode.Mouse0));
		// If Right Button is clicked Camera will move.
		/*
		while (Input.GetKeyDown(KeyCode.Mouse0)) {
			print ("S");

			//float h = horizontalSpeed * Input.GetAxis ("Mouse Y");
			//float v = verticalSpeed * Input.GetAxis ("Mouse X");
			//transform.Translate(v,h,0);
		}
	*/

	}
}
