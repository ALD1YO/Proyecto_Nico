using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour {

public void PlayGame(){
	SceneManager.LoadScene
	(SceneManager.GetActiveScene().buildIndex +1);
	//This shit loads the next level in the queue
}

public void QuitGame(){
	Debug.Log("QUIT");
	Application.Quit();
}

}

/*****************RULES****************/
/*Everytime I want to change scenes in Unity,
Include
using UnityEngine.SceneManagement;
*/