using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sonido_Ventana : MonoBehaviour {

	// Use this for initialization
	bool Repetir = false;
	public AudioClip MusicClip;

	public AudioSource MusicSource;
	void Start () {
		MusicSource.clip = MusicClip;
	}
	
	
/* 
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space))
		{
			MusicSource.Play();
		}
	}
*/
	void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name == "RigidBodyFPSController" && Repetir ==false)
        {
            Debug.Log("Colision detectada");
            MusicSource.Play();
			Repetir = true;
        }
        /*
        GameObject otherObj = collision.gameObject;
        Debug.Log("Collided with: " + otherObj);
        */
    }
}
