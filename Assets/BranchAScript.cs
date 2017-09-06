using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BranchAScript : MonoBehaviour {

	public float startedTime;

	// Use this for initialization
	void Start () {
		startedTime = Time.time;
		Debug.Log("Hi I just started");
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log("Elapsed Time : " + (Time.time-startedTime));
	}
}
