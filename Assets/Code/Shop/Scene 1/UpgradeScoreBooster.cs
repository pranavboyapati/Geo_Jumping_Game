//import libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeScoreBooster : MonoBehaviour
{
    //initialize variables
    public int coins;
    public string scoreBoosterStage;

    //this function upgrades the booster if the player has enough coins, else tells them they don't have enough coins for the upgrade
    public void ScoreBoosterUpgrade()
    {
        coins = GetInt("Coins");

        if (coins >= 2500)
        {
            coins -= 2500;
            SetInt("Coins", coins);

            scoreBoosterStage = GetString("ScoreBoosterStage");
            
            if (scoreBoosterStage == "Stage 1")
            {
                scoreBoosterStage = "Stage 2";
            }
            else if (scoreBoosterStage == "Stage 2")
            {
                scoreBoosterStage = "Stage 3";
            }
            else if (scoreBoosterStage == "Stage 3")
            {
                scoreBoosterStage = "Stage 4";
            }
            else if (scoreBoosterStage == "Stage 4")
            {
                scoreBoosterStage = "Stage 5";
            }

            SetString("ScoreBoosterStage", scoreBoosterStage);
        }

        else
        {
            SetString("NotEnoughCoinsForScoreBooster", "True");
        }
    }

    //this function retreives the value stored at the specified keyname in the playerprefs dictionary
    public int GetInt(string Keyname)
    {
        return PlayerPrefs.GetInt(Keyname);
    }

    //this function stores the specified value at the specified keyname in the playerprefs dictionary
    public void SetInt(string Keyname, int Value)
    {
        PlayerPrefs.SetInt(Keyname, Value);
    }

    //this function retreives the value stored at the specified keyname in the playerprefs dictionary
    public string GetString(string Keyname)
    {
        return PlayerPrefs.GetString(Keyname);
    }

    //this function stores the specified value at the specified keyname in the playerprefs dictionary
    public void SetString(string Keyname, string Value)
    {
        PlayerPrefs.SetString(Keyname, Value);
    }
}
