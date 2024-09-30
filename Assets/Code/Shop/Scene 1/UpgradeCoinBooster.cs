//import libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeCoinBooster : MonoBehaviour
{
    //initialize variables
    public int coins;
    public string coinBoosterStage;

    //this function upgrades the booster if the player has enough coins, else tells them they don't have enough coins for the upgrade
    public void CoinBoosterUpgrade()
    {
        coins = GetInt("Coins");

        if (coins >= 2500)
        {
            coins -= 2500;
            SetInt("Coins", coins);

            coinBoosterStage = GetString("CoinBoosterStage");

            if (coinBoosterStage == "Stage 1")
            {
                coinBoosterStage = "Stage 2";
            }
            else if (coinBoosterStage == "Stage 2")
            {
                coinBoosterStage = "Stage 3";
            }
            else if (coinBoosterStage == "Stage 3")
            {
                coinBoosterStage = "Stage 4";
            }
            else if (coinBoosterStage == "Stage 4")
            {
                coinBoosterStage = "Stage 5";
            }

            SetString("CoinBoosterStage", coinBoosterStage);
        }
        
        else
        {
            SetString("NotEnoughCoinsForCoinBooster", "True");
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
