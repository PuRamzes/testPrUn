using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nextAnim : MonoBehaviour {

	public GameObject player;

	Animator animator;

	// Use this for initialization
	void Start () {
		animator = player.GetComponent<Animator>();
		bool nxt = animator.GetBool("nxt"); //this bool defaults to false
		print(nxt);

	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnTriggerEnter(Collider other){
		animator.SetBool ("nxt", true);
		print (other.name + "В НУЖНОЙ ТОЧКЕ");
	}

	void OnTriggerExit(Collider other){
		animator.SetBool ("nxt", false);
		print (other.name + "УШЕЛ");
	}
		
}
