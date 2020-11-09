using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionMenuController : MonoBehaviour {


	void Start () {

	}

	public void GoBackButtonInOption(){
		SceneManager.LoadScene("MainMenu");
	}

}
