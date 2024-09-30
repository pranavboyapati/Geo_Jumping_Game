//import libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyCoinBoosterButtonText : MonoBehaviour
{
    //initialize variables
    public string CoinBoosterStage;

    //this function is called once per frame update
    //this function removes purchase button components if the upgrade is at the max stage
    public void Update()
    {
        CoinBoosterStage = GetString("CoinBoosterStage");

        if (CoinBoosterStage == "Stage 5")
        {
            Destroy(GetComponent<Text>());
        }
    }

    //this function retreives the value stored at the specified keyname in the playerprefs dictionary
    public string GetString(string Keyname)
    {
        return PlayerPrefs.GetString(Keyname);
    }
}
