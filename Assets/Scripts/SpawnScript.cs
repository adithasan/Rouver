using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour {

	//This script spawns object on the edge of the screen

	public Transform [] PossibleSpawnPositions;
	public Rigidbody2D [] SpawnPrefabs;
	public float SpawnInterval = 2.5f;

	void Start () {

		//0.5 seconds after the game starts, a new object is
		//spawned every "SpawnInterval"

		InvokeRepeating("SpawnObjects", 0.5f, SpawnInterval);
	}
	// //for a computer version
	// void Update(){
	//
	// 	//If P is pressed it goes to the pause menu
	//
	// 	if (Input.GetButtonDown("Fire1")){
	// 		//change state to pause and bring up ChangeStates function
	// 		GameObject.Find("Main Camera").GetComponent<MainControllerScript>().ChangeStates(MainControllerScript.States.Pause);
	// 	}
	// }

	void SpawnObjects(){

		//this function uses GetSpawnPosition to get where to Spawn
		//and then spawns a random object

		Rigidbody2D clone;
		Transform SpawnPosition = GetSpawnPosition();
		int PrefabIndex = Random.Range(0, SpawnPrefabs.Length);
		clone = Instantiate(SpawnPrefabs[PrefabIndex], SpawnPosition.position, SpawnPosition.rotation) as Rigidbody2D;
	}

	Transform GetSpawnPosition(){

		//This function calculates a random spawn point and returns it
		//The possible options are the positions of the empty objects
		//placed in the game scene, they can be moved or added/removed

		int RandomIndex = Random.Range(0, PossibleSpawnPositions.Length);
		return PossibleSpawnPositions[RandomIndex];
	}
}
