using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour {

	public int coll = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown(){
		print ("s");
		transform.localScale = 
			new Vector3 (transform.localScale.x / 2f, transform.localScale.y / 2f, transform.localScale.z / 2f);
	}

	void OnCollisionEnter(Collision other){
		//print (other.gameObject.name + "ENTER");
	}

	void OnCollisionStay(Collision other){
		print (other.gameObject.name + "STAY");
	}

	void OnCollisionExit(Collision other){
		print (other.gameObject.name + "Exit");
	}


	void OnTriggerEnter(Collider other){
		coll++;
		print (other.name + "COLLIDER");
	}


}
