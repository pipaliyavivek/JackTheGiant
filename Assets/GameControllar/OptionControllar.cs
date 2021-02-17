 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionControllar : MonoBehaviour
{

    [SerializeField]
    public GameObject EasySign, MediumSign, HardSign;  
    void Start()
    {
        SetDifficulty();
        GamePrefences.SetMusicState(0);
    }
     void SetInitialDifficulty(string difficulty)
    {
        switch (difficulty)
        {
            case "easy":
               // EasySign.SetActive(true);
                MediumSign.SetActive(false);
                HardSign.SetActive(false);
                break;

            case "medium":
                EasySign.SetActive(false );
                HardSign.SetActive(false);
                break;

            case "hard":
                EasySign.SetActive(false);
                MediumSign.SetActive(false);
                break;
        }
    }
    void SetDifficulty()
    {
        if(GamePrefences.GetEasyDifficultyState ()==1)
        {
            SetInitialDifficulty("easy");
        }
        if (GamePrefences.GetMediumDifficultyState () == 1)
        {
            SetInitialDifficulty("medium");
        }
        if (GamePrefences.GetHardDifficultyState () == 1)
        {
            SetInitialDifficulty("hard");
        }
    }
    public void EasyDifficulty()
    {
        GamePrefences.SetEasyDifficultyState(1);
        GamePrefences.SetMediumDifficultyState(0);
        GamePrefences.SetHardDifficultyState(0);

        EasySign.SetActive(true);
        MediumSign.SetActive(false);
        HardSign.SetActive(false);
    }
    public void MediumDifficulty()
     {
        GamePrefences.SetEasyDifficultyState(0);
        GamePrefences.SetMediumDifficultyState(1);
        GamePrefences.SetHardDifficultyState(0);

        EasySign.SetActive(false );
        MediumSign.SetActive(true);
        HardSign.SetActive(false);
    }
    public void hardDifficulty()
     {
        GamePrefences.SetEasyDifficultyState(0);
        GamePrefences.SetMediumDifficultyState(0);
        GamePrefences.SetHardDifficultyState(1);

        EasySign.SetActive(false);
        MediumSign.SetActive(false );
        HardSign.SetActive(true);
    }
        // Update is called once per frame
    void Update()
    {
        
    }
    public void  backbutton()
    {
        Application.LoadLevel("MainMenu");
    }
}
