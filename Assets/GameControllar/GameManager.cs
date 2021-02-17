using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [HideInInspector]
    public bool gameStartedFromMainMenu, gameRestartedAfterPlayerDie;

    [HideInInspector]
    public int score, coinScore, lifeScore;     
    
    void Awake()
    {   
        MakeSingalton();
    }
    void Start()
    {       
        InitializeVariable();
    }
    void OnLevelWasLoaded()
     {
        if(SceneManager.GetActiveScene().name == "jack and Giant")
        {
            Debug.Log("jack and Giant Scene");
            if(gameRestartedAfterPlayerDie)
            {

                GamePlyControllar.instance.SetScore(score);
                GamePlyControllar.instance.SetCoinScore(coinScore);
                GamePlyControllar.instance.SetLifeScore(lifeScore);

                PlayerScore.scoreCount = score;
                PlayerScore.coinCount = coinScore;
                PlayerScore.lifeCount = lifeScore;
            }
          else if (gameStartedFromMainMenu)
            {
                //Debug.Log("Game Started From Main Menu");
                PlayerScore.scoreCount = 0 ;
                PlayerScore.coinCount = 0;
                PlayerScore.lifeCount = 2;
                Debug.Log("access");
                GamePlyControllar.instance.SetScore(0);
                GamePlyControllar.instance.SetCoinScore(0);
                GamePlyControllar.instance.SetLifeScore(2);
            }

        }
    }
    void InitializeVariable()
    {
        if(!PlayerPrefs.HasKey("Game Initialized"))
        {
            GamePrefences.SetEasyDifficultyState(0);
            GamePrefences.SetHardDifficultyCoinScore(0);
            GamePrefences.SetEasyDifficultyHighscore(0);

            GamePrefences.SetMediumDifficultyState (1);
            GamePrefences.SetMediumDifficultyCoinScore(0);
            GamePrefences.SetMediumDifficultyHighscore(0);

            GamePrefences.SetHardDifficultyState(1);
            GamePrefences.SetHardDifficultyCoinScore(0);
            GamePrefences.SetHardDifficultyCoinScore(0);

            GamePrefences.SetMusicState(0);

            PlayerPrefs.SetInt("Game Initialized", 123);
        }
    }
    void MakeSingalton()
    {
        instance = this;
        DontDestroyOnLoad(gameObject);
        /*if (instance != null) {
            Destroy(gameObject);
        }
        else {
            DontDestroyOnLoad(gameObject);
            instance = this;
        }*/
    }
    public void CheckGameStatus(int score, int coinScore, int lifeScore)
    {
        Debug.Log("Chech game status");
        if (lifeScore < 0)
        {
            Debug.Log("LifeSCore<2");
            if (GamePrefences .GetEasyDifficultyState () == 1)
            {
                Debug.Log("GetEasyLevel");
                int highScore = GamePrefences.GetEasyDifficultyHighscore();
                int coinHighScore = GamePrefences.GetEasyDifficultyCoinScore();
                if(highScore < score )
                {
                    Debug.Log("Score");
                    GamePrefences.SetEasyDifficultyHighscore(score);
                }
                if(coinHighScore < coinScore )
                {
                    Debug.Log("CoinScore");
                    GamePrefences.SetEasyDifficultyCoinScore (coinScore);
                }
            }
            if (GamePrefences.GetMediumDifficultyState() == 1)
            {
                Debug.Log("MediumLevel");
                int highScore = GamePrefences.GetMediumDifficultyHighscore ();
                int coinHighScore = GamePrefences.GetMediumDifficultyCoinScore ();

                if (highScore < score)
                {
                    Debug.Log("7");
                    GamePrefences.SetMediumDifficultyHighscore (score);
                }
                if (coinHighScore < coinScore)
                {
                 //  Debug.Log("8");
                    GamePrefences.SetMediumDifficultyCoinScore(coinScore);

                }
            }
            if (GamePrefences.GetHardDifficultyState () == 1)
            {
                Debug.Log("HardLevel");
                int highScore = GamePrefences.GetHardDifficultyHighscore();
                int coinHighScore = GamePrefences.GetHardDifficultyCoinScore();

                if (highScore < score)
                {
                //    Debug.Log("10");
                    GamePrefences.SetHardDifficultyHighscore(score);
                }
                if (coinHighScore < coinScore)
                {
                  //  Debug.Log("11");
                    GamePrefences.SetHardDifficultyCoinScore(coinScore);

                }
            }
            gameStartedFromMainMenu = false;
            gameRestartedAfterPlayerDie = false;

            GamePlyControllar.instance.gameOverShowpenal(score ,coinScore);
        }
        else
        {
            //debug.Log("12");
            this.score = score;
            this.coinScore = coinScore;
            this.lifeScore = lifeScore;

            //GamePlyControllar.instance.SetScore(score );
            //GamePlyControllar.instance.SetCoinScore(coinScore );
            //GamePlyControllar.instance.SetLifeScore(lifeScore );

            gameStartedFromMainMenu = false;
            gameRestartedAfterPlayerDie = true ;
            GamePlyControllar.instance.PlayerDiedRestartedgame(); 
        }
    }
}
