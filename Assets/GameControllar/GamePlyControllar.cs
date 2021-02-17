using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GamePlyControllar : MonoBehaviour
{
    public static GamePlyControllar instance;

    [SerializeField]
    private Text Scoretext, CoinText, Lifetext,GameOverCointext, GameOverScoreText;

    [SerializeField]
    private GameObject PausePenal,GameOverPenal;
    [SerializeField]
    private GameObject  Readybutton;
    void Awake()
    {
        MakeInstance();
        Time.timeScale = 0f;
          
    }
    void MakeInstance()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    public void gameOverShowpenal(int Finalscore, int finalcoinscore)
    {
        Debug.Log("GameOverPenal");
        GameOverPenal.SetActive(true);
        GameOverCointext.text = Finalscore.ToString();
        GameOverScoreText.text = finalcoinscore.ToString();
        StartCoroutine(GameOverLoadMainMenu());

    }
    public void PlayerDiedRestartedgame()
    {
        StartCoroutine(PlayerDiedRetart());
    }
    IEnumerator PlayerDiedRetart()
    {
        yield return new WaitForSeconds(1f);
       //    Application.LoadLevel("jack and Giant");
        SceneFadere.instance.LoadLevel("jack and Giant");


    }
    IEnumerator GameOverLoadMainMenu()
    {
        yield return new WaitForSeconds(2f);
        // Application.LoadLevel("MainMenu");
        SceneFadere.instance.LoadLevel("MainMenu");

    }
    public void SetScore(int score)
    {
        //Debug.Log("Your Scor="+score);
        Scoretext.text = "x" + score;
    }
    public void SetCoinScore(int coinScore)
    {
        Debug.Log("CoinScore::"+coinScore);

        CoinText.text = "x" + coinScore;
    }
    public void SetLifeScore(int lifeScore)
    {
        Debug.Log("LifeScore" +lifeScore);
       
        Lifetext.text = "x" + lifeScore;
     //   Debug.Log(Lifetext);
    }
    
   
    public void PauseGame()
    {
        Time.timeScale = 0f;
        PausePenal.SetActive(true);
    }
    public void ResumeGame()
    {
        Time.timeScale = 1f;
        PausePenal.SetActive(false);
    }
    public void QuiteGame()
    {
        Time.timeScale = 1f;
     //   Application.LoadLevel("MainMenu");
        SceneFadere.instance.LoadLevel("MainMenu");


    }
    public void Startthegamebutton()
    {
        Time.timeScale = 1f;
        Readybutton.SetActive(false);
    }
    
}
