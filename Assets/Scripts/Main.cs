using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour {

	public GameObject obj;
	private Light light;

	// Use this for initialization
	void Start () {
		print ("create light");
		light = GetComponent<Light> ();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyUp(KeyCode.F)){
			light.enabled = !light.enabled; 
		}
		if(Input.GetKeyUp(KeyCode.KeypadMinus)){
			light.intensity--;
		}
		if(Input.GetKeyUp(KeyCode.KeypadPlus)){
			light.intensity++;
		}


		if(Input.GetKeyUp(KeyCode.Keypad0)){
			obj.GetComponent<Renderer> ().material.color = Color.red;
			//obj.SetActive (false);
			//Destroy (obj);
		}
		//obj.GetComponent<Renderer> ().transform.localScale += new Vector3 (0.1f,0.1f,0);
			
	}
}
