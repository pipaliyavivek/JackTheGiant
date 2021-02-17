using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GamePrefences 
{
	public static string EasyDifficulty = "EasyDifficulty";
	public static string MediumDifficulty = "MediumDifficulty";
	public static string HardDifficulty = "HardDifficulty";

	public static string EasyDifficultyHighScore = "EasyDifficultyHighScore";
	public static string MediumDifficultyHighScore = "MediumDifficultyHighScore";
	public static string HardDifficultyHighScore = "HardDifficultyHighScore";

	public static string EasyDifficultyCoinScore = "EasyDifficultyCoinScore";
	public static string MediumDifficultyCoinScore = "MediumDifficultyCoinScore";
	public static string HardDifficultyCoinScore = "HardDifficultyCoinScore";

	public static string IsTheMusicOn = "IsTheMusicOn";

    

    public static int GetMusicState()
	{
		return PlayerPrefs.GetInt(GamePrefences .IsTheMusicOn);
	}

	// 0 is off - 1 is on
	public static void SetMusicState(int state)
	{
		PlayerPrefs.SetInt(GamePrefences.IsTheMusicOn, state);
	}

	public static int GetEasyDifficultyState()
	{
		return PlayerPrefs.GetInt(GamePrefences .EasyDifficulty);
	}

	public static void SetEasyDifficultyState(int state)
	{
		PlayerPrefs.SetInt(GamePrefences.EasyDifficulty, state);
	}

	public static int GetMediumDifficultyState()
	{
		return PlayerPrefs.GetInt(GamePrefences.MediumDifficulty);
	}

	public static void SetMediumDifficultyState(int state)
	{
		PlayerPrefs.SetInt(GamePrefences .MediumDifficulty, state);
	}

	public static int GetHardDifficultyState()
	{
		return PlayerPrefs.GetInt(GamePrefences.HardDifficulty);
	}
	public static void SetHardDifficultyState(int state)
	{
		PlayerPrefs.SetInt(GamePrefences .HardDifficulty, state);
	}
	public static int GetEasyDifficultyHighscore()
	{
		return PlayerPrefs.GetInt(GamePrefences .EasyDifficultyHighScore);
	}
	public static void SetEasyDifficultyHighscore(int score)
	{
		PlayerPrefs.SetInt(GamePrefences.EasyDifficultyHighScore, score);
	}
	public static int GetMediumDifficultyHighscore()
	{
		return PlayerPrefs.GetInt(GamePrefences .MediumDifficultyHighScore);
	}
	public static void SetMediumDifficultyHighscore(int score)
	{
		PlayerPrefs.SetInt(GamePrefences .MediumDifficultyHighScore, score);
	}

    internal static void SetInt(string v1, int v2)
    {
        throw new NotImplementedException();
    }

    public static int GetHardDifficultyHighscore()
	{
		return PlayerPrefs.GetInt(GamePrefences.HardDifficultyHighScore);
	}
	public static void SetHardDifficultyHighscore(int score)
	{
		PlayerPrefs.SetInt(GamePrefences.HardDifficultyHighScore, score);
	}
	public static int GetEasyDifficultyCoinScore()
	{
		return PlayerPrefs.GetInt(GamePrefences.EasyDifficultyCoinScore);
	}
	public static void SetEasyDifficultyCoinScore(int score)
	{
		PlayerPrefs.SetInt(GamePrefences.EasyDifficultyCoinScore, score);
	}
	public static int GetMediumDifficultyCoinScore()
	{
		return PlayerPrefs.GetInt(GamePrefences.MediumDifficultyCoinScore);
	}
	public static void SetMediumDifficultyCoinScore(int score)
	{
		PlayerPrefs.SetInt(GamePrefences.MediumDifficultyCoinScore, score);
	}
	public static int GetHardDifficultyCoinScore()
	{
		return PlayerPrefs.GetInt(GamePrefences.HardDifficultyCoinScore);
	}
	public static void SetHardDifficultyCoinScore(int score)
	{
		PlayerPrefs.SetInt(GamePrefences.HardDifficultyCoinScore, score);
	}

}
