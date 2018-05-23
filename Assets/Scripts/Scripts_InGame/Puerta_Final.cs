using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puerta_Final : MonoBehaviour {

	 public Transform player;
	 public GameObject Destruir_ganar;
	//public GameObject Object_to_Grab;
	public float Distancia_Limite =  1.0f;
	
	// Update is called once per frame
	void Update () {
		float dist = Vector3.Distance(gameObject.transform.position, player.position);

		 if (dist <= Distancia_Limite)

        {
			if(Input.GetKeyDown("e")){
			print("e key was pressed");
			Destroy(Destruir_ganar);
			}
        }
	}
}
