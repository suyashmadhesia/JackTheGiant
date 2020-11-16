using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GamePrefrences {

	public static string EasyDifficulty = "EasyDifficulty";
	public static string MediumDifficulty = "MediumDifficulty";
	public static string HardDifficulty = "HardDifficulty";

	public static string EasyDifficultyHighScore = "EasyDifficultyHighScore";
	public static string MediumDifficultyHighScore = "MediumDifficultyHighScore";
	public static string HardDifficultyHighScore = "HardDifficultyHighScore";

	public static string EasyDifficultyCoinScore = "EasyDifficultyCoinScore";
	public static string MediumDifficultyCoinScore = "MediumDifficultyCoinScore";
	public static string HardDifficultyCoinScore = "HardDifficultyCoinScore";

	public static string IsMusicOn = "IsMusicOn";

	//NOTE we are goin use integer to represent the boolean variable 0 = false 1 = True;

	public static void SetMusicState(int status){
		PlayerPrefs.SetInt(GamePrefrences.IsMusicOn, status);
	}

	public static int GetMusicState () {
		return PlayerPrefs.GetInt(GamePrefrences.IsMusicOn);
	}

	public static void SetEasyDifficulty(int difficulty) {
		PlayerPrefs.SetInt(GamePrefrences.EasyDifficulty, difficulty);
	}

	public static int GetEasyDifficulty () {
		return PlayerPrefs.GetInt(GamePrefrences.EasyDifficulty);
	}

	public static void SetMediumDifficulty(int difficulty) {
		PlayerPrefs.SetInt(GamePrefrences.MediumDifficulty, difficulty);
	}

	public static int GetMediumDifficulty () {
		return PlayerPrefs.GetInt(GamePrefrences.MediumDifficulty);
	}

	public static void SetHardDifficulty(int difficulty) {
		PlayerPrefs.SetInt(GamePrefrences.HardDifficulty, difficulty);
	}

	public static int GetHardDifficulty () {
		return PlayerPrefs.GetInt(GamePrefrences.HardDifficulty);
	}

	public static void SetEasyDifficultyHighScore(int score) {
		PlayerPrefs.SetInt(GamePrefrences.EasyDifficultyHighScore, score);
	}

	public static int GetEasyDifficultyHighScore () {
		return PlayerPrefs.GetInt(GamePrefrences.EasyDifficultyHighScore);
	}

	public static void SetMediumDifficultyHighScore(int score) {
		PlayerPrefs.SetInt(GamePrefrences.MediumDifficultyHighScore, score);
	}

	public static int GetMediumDifficultyHighScore () {
		return PlayerPrefs.GetInt(GamePrefrences.MediumDifficultyHighScore);
	}

	public static void SetHardDifficultyHighScore(int score) {
		PlayerPrefs.SetInt(GamePrefrences.HardDifficultyHighScore, score);
	}

	public static int GetHardDifficultyHighScore () {
		return PlayerPrefs.GetInt(GamePrefrences.HardDifficultyHighScore);
	}

	public static void SetEasyDifficultyCoinScore(int score) {
		PlayerPrefs.SetInt(GamePrefrences.EasyDifficultyCoinScore, score);
	}

	public static int GetEasyDifficultyCoinScore () {
		return PlayerPrefs.GetInt(GamePrefrences.EasyDifficultyCoinScore);
	}

	public static void SetMediumDifficultyCoinScore(int score) {
		PlayerPrefs.SetInt(GamePrefrences.MediumDifficultyCoinScore, score);
	}

	public static int GetMediumDifficultyCoinScore () {
		return PlayerPrefs.GetInt(GamePrefrences.MediumDifficultyCoinScore);
	}

	public static void SetHardDifficultyCoinScore(int score) {
		PlayerPrefs.SetInt(GamePrefrences.HardDifficultyCoinScore, score);
	}

	public static int GetHardDifficultyCoinScore () {
		return PlayerPrefs.GetInt(GamePrefrences.HardDifficultyCoinScore);
	}

}
