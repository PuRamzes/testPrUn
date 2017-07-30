using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//для текста

public class meGUI : MonoBehaviour {

	public GameObject objwithScript;

	private Text txt;

	Click click;

	// Use this for initialization
	void Start () {
		txt = GameObject.Find ("Text").GetComponent<Text>();
		click = objwithScript.GetComponent<Click> ();
	}
	
	// Update is called once per frame
	void Update () {
		txt.text = click.coll.ToString();
	}
}
