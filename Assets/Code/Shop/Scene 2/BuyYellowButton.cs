//import libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyYellowButton : MonoBehaviour
{
    //initialize variables
    public int coins;
    
    //purchase the skin if the user has enough coins, else tell them they don't have enough coins
    public void BuyYellow()
    {
        coins = GetInt("Coins");

        if (coins >= 5000)
        {
            coins -= 5000;
            SetInt("Coins", coins);
            SetString("YellowOwned", "True");
        }
        else
        {
            SetString("NotEnoughCoinsForYellow", "True");
        }
    }

    //this function retreives the value at the specified keyname in the playerprefs dictionary
    public int GetInt(string Keyname)
    {
        return PlayerPrefs.GetInt(Keyname);
    }

    //this function stores the specified value at the specified keyname in the playerprefs dictionary
    public void SetInt(string Keyname, int Value)
    {
        PlayerPrefs.SetInt(Keyname, Value);
    }

    //this function stores the specified value at the specified keyname in the playerprefs dictionary
    public void SetString(string Keyname, string Value)
    {
        PlayerPrefs.SetString(Keyname, Value);
    }
}
