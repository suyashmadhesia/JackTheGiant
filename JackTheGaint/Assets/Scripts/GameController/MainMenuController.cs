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
		CheckToPlayTheMusic ();
	}

	void CheckToPlayTheMusic(){
		if(GamePrefrences.GetMusicState () == 1){
			MusicController.instance.PlayMusic(true);
			musicButton.image.sprite = musicIcon[1];
		}
		else{
			MusicController.instance.PlayMusic(false);
			musicButton.image.sprite = musicIcon[0];
		}
	}

	public void StartGame(){
		Gamemanger.instance.gameStartedFromMainMenu = true;
		//SceneManager.LoadScene("GameplayScene");
		SceneFader.instance.LoadLevel("GameplayScene");
	}

	public void GoToHighScoreMenu(){
		SceneManager.LoadScene("HighscoreScene");
			//SceneFader.instance.LoadLevel("HighscoreScene");
	}

	public void GotoOptionMenu(){
		SceneManager.LoadScene("OptionScene");
	}

	public void QuitScene(){
		Application.Quit();
	}

	public void MusicButton(){
		if(GamePrefrences.GetMusicState() == 0){
			GamePrefrences.SetMusicState(1);
			MusicController.instance.PlayMusic(true);
			musicButton.image.sprite = musicIcon[1];
		}
		else if(GamePrefrences.GetMusicState() == 1 ){
			GamePrefrences.SetMusicState(0);
			MusicController.instance.PlayMusic(false);
			musicButton.image.sprite = musicIcon[0];
		}
	}

}
