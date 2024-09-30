//import libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreChanger : MonoBehaviour
{
    //initialize variables
    public int Score;
    public string ScoreBoosterStage;
    
    //this function is called repeatedly on the time interval specified in the project settings file
    //this function updates the score with consideration given to the upgrades purchased by the player, displays this score, and stores it in the globally accessible playerprefs dictionary
    public void FixedUpdate()
    {
        Score = GetInt("Score");
        ScoreBoosterStage = GetString("ScoreBoosterStage");

        if (ScoreBoosterStage == "Stage 1")
        {
            Score += 1;
        }
        if (ScoreBoosterStage == "Stage 2")
        {
            Score += 2;
        }
        if (ScoreBoosterStage == "Stage 3")
        {
            Score += 3;
        }
        if (ScoreBoosterStage == "Stage 4")
        {
            Score += 4;
        }
        if (ScoreBoosterStage == "Stage 5")
        {
            Score += 5;
        }

        SetInt("Score", Score);

        GetComponent<UnityEngine.UI.Text>().text = "Score: " + Score;
    }

    //this function retrieves the value stored in the playerprefs dictionary at the specified keyname
    public string GetString(string Keyname)
    {
        return PlayerPrefs.GetString(Keyname);
    }

    //this function retrieves the value stored in the playerprefs dictionary at the specified keyname
    public int GetInt(string Keyname)
    {
        return PlayerPrefs.GetInt(Keyname);
    }

    //this function stores the specified value at the specified keyname in the playerprefs dictionary
    public void SetInt(string Keyname, int Value)
    {
        PlayerPrefs.SetInt(Keyname, Value);
    }
}
