using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Victory_Condition : MonoBehaviour {

	public GameObject Perilla_1;
	public GameObject Perilla_2;
	public GameObject Perilla_3;

	public GameObject Puerta_Final;
	
	// Update is called once per frame
	void Update () {
		if(!Perilla_1.activeSelf && !Perilla_2.activeSelf && !Perilla_3.activeSelf){
			Puerta_Final.SetActive(true);
			//Debug.Log("Ya ganaste champion");
		}
	}
}
