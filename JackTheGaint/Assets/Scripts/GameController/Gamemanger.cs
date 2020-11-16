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

			gameStartedFromMainMenu = false;
			gameRestartedAfterPlayerDies = false;

			GameplayController.instance.GameoverShowPanel(score, coinScore);
		}
		else{
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
