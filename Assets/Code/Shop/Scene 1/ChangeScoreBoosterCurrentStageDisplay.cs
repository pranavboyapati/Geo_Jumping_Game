//import libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScoreBoosterCurrentStageDisplay : MonoBehaviour
{
    //initialize variables
    public string scoreBoosterStage;
    
    //this function is called once per frame update
    //this function displays the current stage of the score booster upgrade
    public void Update()
    {
        scoreBoosterStage = GetString("ScoreBoosterStage");
        GetComponent<UnityEngine.UI.Text>().text = "Score Booster: " + scoreBoosterStage;
    }

    //this function retreives the value at the specified keyname in the playerprefs dictionary
    public string GetString(string Keyname)
    {
        return PlayerPrefs.GetString(Keyname);
    }
}
