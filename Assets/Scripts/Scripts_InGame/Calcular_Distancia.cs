using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calcular_Distancia : MonoBehaviour {

    public Transform player;
	public GameObject Object_to_Grab;
	public float Distancia_Limite =  1.0f;
	bool Cerquita = false;
	
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		  float dist = Vector3.Distance(gameObject.transform.position, player.position);

        if (dist <= Distancia_Limite)

        {

            //Cerquita = true;
			Debug.Log("Te estoy tocando");

			if(Input.GetKeyDown("e")){
			print("e key was pressed");
			Object_to_Grab.SetActive(false);
			}
        }
		
	}
}
