using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuScript : MonoBehaviour {
	//This script controls the button behaviour of the pause menu
	
	public void ResumeButtonPress(){
		GameObject.Find("Main Camera").GetComponent<MainControllerScript>().ChangeStates(MainControllerScript.States.Game);
	}
	public void RestartButtonPress(){
		SceneManager.LoadScene("GameScreen");
	}

	public void MainMenuPress(){
		SceneManager.LoadScene("Main Menu");
	}

	public void ExitPress(){
		Application.Quit();
	}
}
