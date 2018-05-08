using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Look_At_Follow : MonoBehaviour {

	public Transform Atarget;
	float mspeed = 1.0f;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt(Atarget.position);
		transform.Translate(0.0f, 0.0f, mspeed*Time.deltaTime);

	}
}
