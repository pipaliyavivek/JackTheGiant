using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuControllar : MonoBehaviour
{
    [SerializeField]
    private Button musicbutton;
    [SerializeField]
    private Sprite[] musicIcons;
    void Start()
    {
        CheckToPlayTheMusic();
    }
    void CheckToPlayTheMusic()
    {
        if(GamePrefences.GetMusicState  () == 1)
        {
            MusicControllar.instance.playMusic(true);
            musicbutton.image.sprite = musicIcons[1];
        }
        else
        {
            MusicControllar.instance.playMusic(false );
            musicbutton.image.sprite = musicIcons[0];
        }
    }
    public void Startgame()
    {
       // GameManager.instance.OnLoadLeval();
        GameManager.instance.gameStartedFromMainMenu = true;
        //Application.LoadLevel("jack and Giant");
        SceneFadere.instance.LoadLevel("jack and Giant");
    }
    public void HighScoreMenu()
    {
        Application.LoadLevel("HighScoreMenu");
    }
    public void OptionMenu()
    {
        Application.LoadLevel("OptionMenu");
    }
    public void quitgame()
    {
        Debug.Log("Game Quit");
      //  SceneFadere.instance.LoadLevel("Game Quit");

        Application.Quit();
    }
    public void MusicButton()
    { 
        if(GamePrefences.GetMusicState() == 0)//false
        {
            GamePrefences.SetMusicState(1);//true
            MusicControllar.instance.playMusic(true);
            musicbutton.image.sprite = musicIcons[1];

        }
        else if(GamePrefences.GetMusicState() == 1)//currently playing
        {
            GamePrefences.SetMusicState(0);//true
            MusicControllar.instance.playMusic(false );
            musicbutton.image.sprite = musicIcons[0 ];
        }
    }
}
