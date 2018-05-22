using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colision_perillas : MonoBehaviour {

	// Use this for initialization
	//public GameObject Jugador;
	private bool colision = false;
	// Collision colision_chida;
	void Start () {
		
	}
	
	void OnCollisionEnter(Collision col){
		if(col.gameObject.name == "RigidBodyFPSController")
        {
            Debug.Log("Colision detectada con Usuario");
			colision = true;
			Debug.Log(colision);
        }

		if(Input.GetKeyDown("e")){
				print("e key was pressed");
				
			}
		colision = false;
		Debug.Log(colision);
	}

	
}
