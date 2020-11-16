using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HighscoreController : MonoBehaviour {

	[SerializeField]
	private Text scoreText, coinText;

	void Start () {
		SetScoreBasedOnDifficulty ();
	}

	void SetScore(int score, int coinScore){
		scoreText.text = score.ToString();
		coinText.text = coinScore.ToString();
	}

	void SetScoreBasedOnDifficulty () {

		if(GamePrefrences.GetEasyDifficulty() == 1){
			SetScore(GamePrefrences.GetEasyDifficultyHighScore(), GamePrefrences.GetEasyDifficultyCoinScore());
		}

		if(GamePrefrences.GetMediumDifficulty() == 1){
			SetScore(GamePrefrences.GetMediumDifficultyHighScore(), GamePrefrences.GetMediumDifficultyCoinScore());
		}

		if(GamePrefrences.GetHardDifficulty() == 1){
			SetScore(GamePrefrences.GetHardDifficultyHighScore(), GamePrefrences.GetHardDifficultyCoinScore());
		}

	}


	public void GoBackButton(){
		SceneManager.LoadScene("MainMenu");
	}
}
