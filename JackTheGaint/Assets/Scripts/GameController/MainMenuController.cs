using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour {

	void Start () {

	}

	public void StartGame(){
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
