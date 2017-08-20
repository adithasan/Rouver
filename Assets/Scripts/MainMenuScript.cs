using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour {
	//This handles the behaviour of the main game menu

	public void PlayPressed(){
		SceneManager.LoadScene("GameScreen");
	}

	public void ExitPressed(){
		Application.Quit();
	}
}
