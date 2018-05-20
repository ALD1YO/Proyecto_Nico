using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Seguir_a_jugador : MonoBehaviour {
	public Transform[] target;
	public float speed;
	public float Distancia_Seguir;
	NavMeshAgent agent;
	private int current;
	void Start(){
		agent = GetComponent<NavMeshAgent>();
	}
	// Update is called once per frame
	void Update () {
		/*if (transform.position != target [current].position) {
			Vector3 pos = Vector3.MoveTowards(transform.position, target[current].position, speed * Time.deltaTime);
			GetComponent<Rigidbody>().MovePosition(pos); 
		} else
			current = (current + 1)%target.Length;
			*/
		if(Vector3.Distance(transform.position, target[0].position) < Distancia_Seguir){
			agent.SetDestination(target[0].position);
			agent.isStopped = false;
		}
		else{
			agent.isStopped = true;
		}
	}
}
