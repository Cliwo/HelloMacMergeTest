using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float horizon = Input.GetAxis ("Horizontal");
		float vertical = Input.GetAxis ("Vertical");

		transform.Translate (new Vector3 (horizon, vertical, 0));
	}
}
