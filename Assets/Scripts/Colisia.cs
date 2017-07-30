using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colisia : MonoBehaviour {

	//public GameObject obj;
	//private GameObject inst_obj;


	void Start () {
	//	inst_obj = Instantiate (obj, new Vector3 (62.85f,1f,45f), Quaternion.identity) as GameObject;
	
	//	inst_obj.GetComponent<Renderer> ().material.color = Color.green;
	}

	void Update () {
	//	float zPos = Input.GetAxis ("Vertical");
	//	inst_obj.transform.Translate (Vector3.forward * speed * zPos * Time.deltaTime);
	}

	void OnCollisionEnter(Collision other){
		print (other.gameObject.name);
	}
}
