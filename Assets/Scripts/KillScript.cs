using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class KillScript : MonoBehaviour {
	//This script handles collisions with objects
	//Awards points when touching collisions
	//Taking away lives when touching dangerous objects

	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "DangerousItems"){
			//lives is stored as a static variable in MainControllerScript
			//If we run out of lives the game is over
			GameObject.Find("Main Camera").GetComponent<MainControllerScript>();
			MainControllerScript.lives --;
			if (MainControllerScript.lives < 0){
				GameObject.Find("Main Camera").GetComponent<MainControllerScript>().ChangeStates(MainControllerScript.States.End);
			}
		}
		else if (other.gameObject.tag == "ScoreItems"){
			//increase score if colliding with score item and destroy the coin
			GameObject.Find("Main Camera").GetComponent<MainControllerScript>();
			MainControllerScript.score ++;
			MainControllerScript.UpdateScore();
			Destroy(other.gameObject);
		}
	}
}
