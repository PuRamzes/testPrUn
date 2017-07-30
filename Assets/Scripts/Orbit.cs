using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour {

	public float turnSpeed = 4.0f;
	public GameObject player;
	private Vector3 offset;

	public float correctionX = 60.0f;
	public float correctionY = 2.0f;
	public float correctionZ = 50.0f;

	// Use this for initialization
	void Start () {


		//offset = new Vector3(player.transform.position.x, player.transform.position.y + 8.0f, player.transform.position.z + 7.0f);

		offset = new Vector3(player.transform.position.x - correctionX, player.transform.position.y + correctionY, player.transform.position.z + 7.0f - correctionZ);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void LateUpdate()
	{
		offset = Quaternion.AngleAxis (Input.GetAxis("Mouse X") * turnSpeed, Vector3.up) * offset;
		transform.position = player.transform.position + offset; 
		transform.LookAt(player.transform.position);
	}
}
