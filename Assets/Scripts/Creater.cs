using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creater : MonoBehaviour {

	public GameObject[] objs;

	[SerializeField]
	private float speed = 4f;

	// Use this for initialization
	void Start (){
		int rand = Random.Range(0, objs.Length -1);
		GameObject obj = Instantiate (objs[rand], new Vector3(60f,1f,45f),Quaternion.identity) as GameObject;//objs[1].transform.position,Quaternion.identity
		obj.GetComponent<Renderer> ().material.color = Color.red;

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
