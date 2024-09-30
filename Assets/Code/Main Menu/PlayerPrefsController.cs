//import libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsController : MonoBehaviour
{
    //this function ensures all playerpref values exist and are initialized properly
    public void Clicked()
    {
        if (PlayerPrefs.HasKey("NotEnoughCoinsForYellow") == false)
        {
            SetString("NotEnoughCoinsForYellow", "False");
        }
        if (PlayerPrefs.HasKey("NotEnoughCoinsForPink") == false)
        {
            SetString("NotEnoughCoinsForPink", "False");
        }
        if (PlayerPrefs.HasKey("NotEnoughCoinsForGreen") == false)
        {
            SetString("NotEnoughCoinsForGreen", "False");
        }
        if (PlayerPrefs.HasKey("YellowOwned") == false)
        {
            SetString("YellowOwned", "False");
        }
        if (PlayerPrefs.HasKey("PinkOwned") == false)
        {
            SetString("PinkOwned", "False");
        }
        if (PlayerPrefs.HasKey("GreenOwned") == false)
        {
            SetString("GreenOwned", "False");
        }
        if (PlayerPrefs.HasKey("ScoreBoosterStage") == false)
        {
            SetString("ScoreBoosterStage", "Stage 1");
        }
        if (PlayerPrefs.HasKey("NotEnoughCoinsForScoreBooster") == false)
        {
            SetString("NotEnoughCoinsForScoreBooster", "False");
        }
        if (PlayerPrefs.HasKey("CoinBoosterStage") == false)
        {
            SetString("CoinBoosterStage", "Stage 1");
        }
        if (PlayerPrefs.HasKey("NotEnoughCoinsForCoinBooster") == false)
        {
            SetString("NotEnoughCoinsForCoinBooster", "False");
        }
        if (PlayerPrefs.HasKey("SelectedSkin") == false)
        {
            SetString("SelectedSkin", "None");
        }
        if (PlayerPrefs.HasKey("GameState") == false)
        {
            SetString("GameState", "Normal");
        }
        if (PlayerPrefs.HasKey("Jumped") == false)
        {
            SetString("Jumped", "False");
        }
        if (PlayerPrefs.HasKey("Coins") == false)
        {
            SetInt("Coins", 0);
        }
        if (PlayerPrefs.HasKey("Score") == false)
        {
            SetInt("Score", 0);
        }
        if (PlayerPrefs.HasKey("PlayerXPosition") == false)
        {
            SetFloat("PlayerXPosition", 0f);
        }
        if (PlayerPrefs.HasKey("PlayerYPosition") == false)
        {
            SetFloat("PlayerYPosition", 0f);
        }
    }

    //this function sets the playerprefs value of the specified key to the specified value when the value is a string
    public void SetString(string Keyname, string Value)
    {
        PlayerPrefs.SetString(Keyname, Value);
    }

    //this function sets the playerprefs value of the specified key to the specified value when the value is an integer
    public void SetInt(string Keyname, int Value)
    {
        PlayerPrefs.SetInt(Keyname, Value);
    }

    //this function sets the playerprefs value of the specified key to the specified value when the value is a float
    public void SetFloat(string Keyname, float Value)
    {
        PlayerPrefs.SetFloat(Keyname, Value);
    }
}
