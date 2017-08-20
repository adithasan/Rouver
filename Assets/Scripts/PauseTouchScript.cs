using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseTouchScript : MonoBehaviour {
	//handles the pause button behaviour for the pause button
	//on the game screen

	public void EnterPauseMenu(){
		GameObject.Find("Main Camera").GetComponent<MainControllerScript>().ChangeStates(MainControllerScript.States.Pause);
	}
}
