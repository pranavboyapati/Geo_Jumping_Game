//import libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyScoreBoosterButton : MonoBehaviour
{
    //initialize variables
    public string ScoreBoosterStage;

    //this function is called once per frame update
    //this function removes the button for purchasing upgrades if the upgrade is at the max stage
    public void Update()
    {
        ScoreBoosterStage = GetString("ScoreBoosterStage");

        if (ScoreBoosterStage == "Stage 5")
        {
            Destroy(GetComponent<Image>());
            Destroy(GetComponent<Button>());
        }
    }

    //this function retreives the value at the specified keyname in the playerprefs dictionary
    public string GetString(string Keyname)
    {
        return PlayerPrefs.GetString(Keyname);
    }
}
