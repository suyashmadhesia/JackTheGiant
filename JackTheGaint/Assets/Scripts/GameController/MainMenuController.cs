using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour {

	[SerializeField]
	private Button musicButton;

	[SerializeField]
	private Sprite[] musicIcon;

	void Start () {

	}



	public void StartGame(){
		Gamemanger.instance.gameStartedFromMainMenu = true;
		SceneManager.LoadScene("GameplayScene");
	}

	public void GoToHighScoreMenu(){
		SceneManager.LoadScene("HighscoreScene");
	}

	public void GotoOptionMenu(){
		SceneManager.LoadScene("OptionScene");
	}

	public void QuitScene(){
		Application.Quit();
	}

	public void MusicButton(){

	}

}
