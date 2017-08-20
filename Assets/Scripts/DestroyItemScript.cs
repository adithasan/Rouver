using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyItemScript : MonoBehaviour {

	//This script controls the lifespan of each spawned object
	//It also adds movement to them if they are in the game mode
	//And stops them from moving if the game is over or paused

	//Most of these public variables have been designed so
	//that they can be easily tweaked when required
	public int LifeSpan = 3;
	public Vector2 force = new Vector2(2, 0);

	void Start(){
		Destroy(gameObject, LifeSpan);
	}

	void FixedUpdate(){
		//Make the objects move when allowed and stop them when not
		GameObject.Find("Main Camera").GetComponent<MainControllerScript>();
		if (MainControllerScript.MovementAllowed == true)
			gameObject.GetComponent<Rigidbody2D>().AddForce(force);
		else
			gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);

	}
}
