using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class OptionMenuController : MonoBehaviour {

	[SerializeField]
	private GameObject easySign, mediumSign, hardSign;

	void Start () {
		SetTheDifficulty ();
	}

	void SetInitialDifficulty(string difficulties){
		switch(difficulties){
			case "easy":
				//easySign.SetActive(true);
				mediumSign.SetActive(false);
				hardSign.SetActive(false);
				break;

			case "medium":
				easySign.SetActive(false);
			//	mediumSign.SetActive(true);
				hardSign.SetActive(false);
				break;

			case "hard":
				easySign.SetActive(false);
				mediumSign.SetActive(false);
				//hardSign.SetActive(true);
				break;
		}
	}

	void SetTheDifficulty () {
		if(GamePrefrences.GetEasyDifficulty() == 1){

			SetInitialDifficulty("easy");

		}
		if(GamePrefrences.GetMediumDifficulty() == 1){

			SetInitialDifficulty("medium");

		}
		if(GamePrefrences.GetHardDifficulty() == 1){

			SetInitialDifficulty("hard");

		}
	}

	public void EasyDifficulty(){
		GamePrefrences.SetEasyDifficulty(1);
		GamePrefrences.SetMediumDifficulty(0);
		GamePrefrences.SetHardDifficulty(0);

		easySign.SetActive(true);
		mediumSign.SetActive(false);
		hardSign.SetActive(false);
	}

	public void MediumDifficulty(){
		GamePrefrences.SetEasyDifficulty(0);
		GamePrefrences.SetMediumDifficulty(1);
		GamePrefrences.SetHardDifficulty(0);

		easySign.SetActive(false);
		mediumSign.SetActive(true);
		hardSign.SetActive(false);
	}
	public void HardDifficulty(){
		GamePrefrences.SetEasyDifficulty(0);
		GamePrefrences.SetMediumDifficulty(0);
		GamePrefrences.SetHardDifficulty(1);

		easySign.SetActive(false);
		mediumSign.SetActive(false);
		hardSign.SetActive(true);
	}

	public void GoBackButtonInOption(){
		SceneManager.LoadScene("MainMenu");
	}

}
