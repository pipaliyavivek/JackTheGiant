using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HighScoreControllar : MonoBehaviour
{
    [SerializeField]
    public Text scoreText, coinText;
    void Start()
    {
        ScoreBaseOnDifficulty();    
    }
    void SetScore(int score,int coinScore)
    {
        scoreText.text = score.ToString();
        coinText.text = coinScore.ToString();

    }
    void ScoreBaseOnDifficulty()
    {
        if(GamePrefences.GetEasyDifficultyState () == 1){
            SetScore(GamePrefences.GetEasyDifficultyHighscore(), GamePrefences.GetEasyDifficultyCoinScore());
        }
        if (GamePrefences.GetMediumDifficultyState() == 1)
        {
            SetScore(GamePrefences.GetMediumDifficultyHighscore(), GamePrefences.GetMediumDifficultyCoinScore());
        }
        if (GamePrefences.GetHardDifficultyState () == 1)
        {
            SetScore(GamePrefences.GetHardDifficultyHighscore(), GamePrefences.GetHardDifficultyCoinScore());
        }
    }
    public void gobacktomainmenu()
    {
        Application.LoadLevel("MainMenu");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
