using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameplayController : MonoBehaviour {

	public static GameplayController instance;
	[SerializeField]
	private Text coinText, lifeText, scoreText, gameoverCoinText, gameoverScoreText;

	[SerializeField]
	private GameObject pausePanel, gameoverPanel;


	void Awake () {

		MakeInstance();

	}

	void MakeInstance() {

		if(instance == null){
			instance = this;
		}

	}

	public void GameoverShowPanel(int finalScore, int finalCoin){

		gameoverPanel.SetActive(true);
		gameoverScoreText.text = finalScore.ToString();
		gameoverCoinText.text = finalCoin.ToString();
		StartCoroutine( GameoverLoadMainMenu() );

	}

	IEnumerator GameoverLoadMainMenu() {

		yield return new WaitForSeconds(2f);
		SceneManager.LoadScene("MainMenu");

	}

	public void SetScore(int score) {
		scoreText.text = "" + score;
	}

	public void SetCoinScore(int coin){
		coinText.text = "x" + coin;
	}

	public void SetLifeScore(int score){
		lifeText.text = "x" + score;
	}

	public void PauseTheGame() {

		Time.timeScale = 0f;
		pausePanel.SetActive(true);

	}

	public void ResumeTheGame(){

		Time.timeScale = 1f;
		pausePanel.SetActive(false);

	}

	public void quitTheGame() {

		Time.timeScale = 1f;
		SceneManager.LoadScene("MainMenu");
		// PlayerScore.scoreCount = 0;
		// PlayerScore.lifeScore = 0;
		// PlayerScore.coinScore = 0;

	}
}
