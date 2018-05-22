using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Song_Delay : MonoBehaviour {

	AudioSource myAudio;
	public GameObject target;
	public float Time_to_Start= 1.0f;
	// Use this for initialization
	void Start () {

		myAudio = GetComponent<AudioSource>();
		myAudio.PlayDelayed(Time_to_Start);
		//target.SetActive(false);
	}

	void Update(){
		if(!myAudio.isPlaying){
			Debug.Log("El Audio no suena");
			target.SetActive(true);
		}


	}
}
