using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainControllerScript : MonoBehaviour {

	public GameObject PauseCanvas;
	public GameObject GameOverCanvas;
	public static bool HighScoreState = false;
	public static bool MovementAllowed;
	public enum States {Game, Pause, End};
	public States State;
	public static int score;
	public static int highscore;
	public static int lives;


	void Awake(){
		//checks if there is a highscore recorded
		lives = 3;
		if (PlayerPrefs.HasKey("Highscore")){
			highscore = PlayerPrefs.GetInt("Highscore");
		}
		else{
			highscore = 0;
			PlayerPrefs.SetInt("Highscore", highscore);
		}
	}

	void Start () {
		//sets the starting score and number of lives
		score = 0;

		ChangeStates(States.Game);
		UpdateScore();
	}


	void Update () {
		UpdateScore();
		Debug.Log("Lives: " + lives);

}

public void ChangeStates(States State){
	switch (State){
		case States.Game:
		{
			//turn on game screen
			//turn off pause and gameover canvas
			//allow movement of objects
			MovementAllowed = true;
			HighScoreState = false;
			if (PauseCanvas.activeSelf == true){
				PauseCanvas.SetActive(false);
			}
			if (GameOverCanvas.activeSelf == true){
				GameOverCanvas.SetActive(false);
			}
			break;
		}
		case States.Pause:
		{
			//turn off control of game screen and gameover canvas
			//dont allow movement of objects
			MovementAllowed = false;
			if (GameOverCanvas.activeSelf == true){
				GameOverCanvas.SetActive(false);
			}
			//turn on Pause canvas
			if (PauseCanvas.activeSelf == false){
				PauseCanvas.SetActive(true);
			}
			break;
		}
		case States.End:
		{
			//turn off control of game screen and pause canvas
			//dont allow moevement of objects
			//reset the number of lives
			MovementAllowed = false;
			HighScoreState = false;
			lives = 3;
			if (PauseCanvas.activeSelf == true){
				PauseCanvas.SetActive(false);
			}
			// turn on GameOver canvas
			if (GameOverCanvas.activeSelf == false){
				GameOverCanvas.SetActive(true);
			}
			break;
		}
		}

	}


	public static void UpdateScore(){
		if (score > highscore){
			//if new highscore set save it
			highscore = score;
			PlayerPrefs.SetInt("Highscore", highscore);

			//activate the text saying new highscore
			if (HighScoreState == false){
					GameObject.Find("NewHighScoreText").GetComponent<RectTransform>().Translate(0,0,2000);
					HighScoreState = true;
			}
		}
		//Display the score, the highscore and the remaining number of lives
		GameObject.Find("Points").GetComponent<Text>().text = "Score: " + score + " Highscore: "+ highscore;
		GameObject.Find("LivesText").GetComponent<Text>().text = "Lives: " + lives;


	}
}
