using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstructionsPanelScript : MonoBehaviour {
	public GameObject InstructionsPanel;
	// Use this for initialization

	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Fire1")){
			InstructionsPanel.SetActive(false);
		}
	}
}
