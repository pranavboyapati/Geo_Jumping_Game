//import libraries
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsWonController : MonoBehaviour
{
    //initialize variables
    public int Score;
    public int ScoreDivisor;
    public double CoinsWon;
    public int CoinsToAdd;
    public int OldCoinsValue;
    public int NewCoinsValue;
    
    //this function is called once when the page is first loaded
    //this function calculates the number of coins the user won based on their score, displays the number of coins won, and updates the globally accessible value
    public void Start()
    {
        ScoreDivisor = 20;
        Score = GetInt("Score");
        CoinsWon = (double)Score / (double)ScoreDivisor;
        CoinsToAdd = (int)Math.Round(CoinsWon);

        GetComponent<UnityEngine.UI.Text>().text = "Coins Won: " + CoinsToAdd;
        
        OldCoinsValue = GetInt("Coins");
        NewCoinsValue = OldCoinsValue + CoinsToAdd;
        SetInt("Coins", NewCoinsValue);
    }

    //this function returns the value stored in the playerprefs dictionary under the entered keyname only if the value is an integer
    public int GetInt(string Keyname)
    {
        return PlayerPrefs.GetInt(Keyname);
    }

    //this function sets the playerprefs value of the specified key to the specified value when the value is an integer
    public void SetInt(string Keyname, int Value)
    {
        PlayerPrefs.SetInt(Keyname, Value);
    }
}
