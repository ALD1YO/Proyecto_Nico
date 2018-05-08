using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision_Test : MonoBehaviour {


    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name == "Shrek_prueba")
        {
            Debug.Log("Colision detectada");
            Destroy(col.gameObject);
        }
        /*
        GameObject otherObj = collision.gameObject;
        Debug.Log("Collided with: " + otherObj);
        */
    }
    
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "Shrek_prueba")
        {
            Debug.Log("Colision detectada");
            Destroy(col.gameObject);
        }
    }
    
}
