//import libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCoinBoosterCurrentStageDisplay : MonoBehaviour
{
    //initialize variables
    public string coinBoosterStage;
    
    //this function is called once per frame update
    //this function displays the current stage of the coin booster upgrade
    public void Update()
    {
        coinBoosterStage = GetString("CoinBoosterStage");
        GetComponent<UnityEngine.UI.Text>().text = "Coin Booster: " + coinBoosterStage;
    }

    //this function retreives the value at the specified keyname in the playerprefs dictionary
    public string GetString(string Keyname)
    {
        return PlayerPrefs.GetString(Keyname);
    }
}
