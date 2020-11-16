using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamemanger : MonoBehaviour {

	public static Gamemanger instance;

	[HideInInspector]
	public bool gameStartedFromMainMenu, gameRestartedAfterPlayerDies;

	[HideInInspector]
	public int score, coinScore, lifescore;

	void Start() {
		InitializeVaribles ();
	}

	void Awake () {
		MakeSingleton ();
	}

	void OnEnable(){
		SceneManager.sceneLoaded += LevelFinishedLoading;
	}

	void OnDisable() {
		SceneManager.sceneLoaded -= LevelFinishedLoading;
	}

	void LevelFinishedLoading(Scene scene, LoadSceneMode mode){
		if(scene.name == "GameplayScene"){

			//print("I am Working");
			if(gameRestartedAfterPlayerDies){

				GameplayController.instance.SetScore(score);
				GameplayController.instance.SetCoinScore(coinScore);
				GameplayController.instance.SetLifeScore(lifescore);

				PlayerScore.scoreCount = score;
				PlayerScore.lifeScore = lifescore;
				PlayerScore.coinScore = coinScore;

			}
			else if(gameStartedFromMainMenu){

				PlayerScore.scoreCount = 0;
				PlayerScore.lifeScore = 2;
				PlayerScore.coinScore = 0;
				GameplayController.instance.SetScore(score);
				GameplayController.instance.SetCoinScore(coinScore);
				GameplayController.instance.SetLifeScore(lifescore);

			}
		}
	}

	void InitializeVaribles() {

		if(!PlayerPrefs.HasKey("Game Initialized")){

			GamePrefrences.SetEasyDifficulty(0);
			GamePrefrences.SetEasyDifficultyCoinScore(0);
			GamePrefrences.SetEasyDifficultyHighScore(0);

			GamePrefrences.SetMediumDifficulty(1);
			GamePrefrences.SetMediumDifficultyCoinScore(0);
			GamePrefrences.SetMediumDifficultyHighScore(0);

			GamePrefrences.SetHardDifficulty(0);
			GamePrefrences.SetHardDifficultyCoinScore(0);
			GamePrefrences.SetHardDifficultyHighScore(0);

			GamePrefrences.SetMusicState(0);

			PlayerPrefs.SetInt("Game Initialized", 123);

		}

	}

	void MakeSingleton () {
		if(instance != null){
			Destroy(gameObject);
		}
		else{
			instance = this;
			DontDestroyOnLoad(gameObject);
		}
	}

	public void CheckGameStatus(int score,int coinScore, int lifescore){
		if(lifescore < 0){

			if(GamePrefrences.GetEasyDifficulty() == 1){
				int highScore = GamePrefrences.GetEasyDifficultyHighScore();
				int coinHighScore = GamePrefrences.GetEasyDifficultyCoinScore();

				if(highScore < score){
					GamePrefrences.SetEasyDifficultyHighScore(score);

				}
				if(coinHighScore < coinScore){
					GamePrefrences.SetEasyDifficultyCoinScore(coinScore);
				}
			}

			if(GamePrefrences.GetMediumDifficulty() == 1){
				int highScore = GamePrefrences.GetMediumDifficultyHighScore();
				int coinHighScore = GamePrefrences.GetMediumDifficultyCoinScore();

				if(highScore < score){
					GamePrefrences.SetMediumDifficultyHighScore(score);

				}
				if(coinHighScore < coinScore){
					GamePrefrences.SetMediumDifficultyCoinScore(coinScore);
				}
			}

			if(GamePrefrences.GetHardDifficulty() == 1){
				int highScore = GamePrefrences.GetHardDifficultyHighScore();
				int coinHighScore = GamePrefrences.GetHardDifficultyCoinScore();

				if(highScore < score){
					GamePrefrences.SetHardDifficultyHighScore(score);

				}
				if(coinHighScore < coinScore){
					GamePrefrences.SetHardDifficultyCoinScore(coinScore);
				}
			}


			gameStartedFromMainMenu = false;
			gameRestartedAfterPlayerDies = false;

			GameplayController.instance.GameoverShowPanel(score, coinScore);
		}
		else {
			this.score = score;
			this.coinScore = coinScore;
			this.lifescore = lifescore;

			GameplayController.instance.SetScore(score);
			GameplayController.instance.SetCoinScore(coinScore);
			GameplayController.instance.SetLifeScore(lifescore);

			gameRestartedAfterPlayerDies = true;
			gameStartedFromMainMenu = false;

			GameplayController.instance.PlayerDiedRestartTheGame();
		}
	}

}
