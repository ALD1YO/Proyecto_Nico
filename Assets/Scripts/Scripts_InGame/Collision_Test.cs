using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision_Test : MonoBehaviour {

    public GameObject target;

    void Start(){
        //agent = GetComponent<NavMeshAgent>();
    }
    
    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name == "Shrek_prueba")
        {
            Debug.Log("Colision detectada con Shrek");
            Destroy(col.gameObject);
        }

        if(col.gameObject.name == "Doll_2"){
            Debug.Log("La mona te atrapo");
            Destroy(target);
        }
        /*
        GameObject otherObj = collision.gameObject;
        Debug.Log("Collided with: " + otherObj);
        */
    }
    /*
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "Shrek_prueba")
        {
            Debug.Log("Colision detectada");
            Destroy(col.gameObject);
        }
    }
     */
    
}
