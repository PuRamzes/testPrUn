using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class curatina : MonoBehaviour {

	public GameObject obj;

	void Start () {
		Invoke ("hi", 5f);
	}

	void hi(){
		print ("hi");
	}

	void Update () {
		if (Input.GetKey (KeyCode.G)) {
			StartCoroutine (instObj ());
		}
	}

	IEnumerator instObj(){
		Instantiate (obj, new Vector3(Random.Range(50f, 100f),1f,45f),Quaternion.identity);
		yield return new WaitForSeconds (1.5f);//sec
	}
}
