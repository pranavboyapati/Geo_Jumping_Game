//import libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NotEnoughCoinsTextChangePink : MonoBehaviour
{
    //initialize variables
    public string notEnoughCoins;

    //this function is called once per frame update
    //this function tells the user they don't have enough coins to purchase the upgrade if that prompt is necessary
    public void Update()
    {
        notEnoughCoins = GetString("NotEnoughCoinsForPink");

        if (notEnoughCoins == "True")
        {
            GetComponent<UnityEngine.UI.Text>().text = "Not Enough Coins";
            Invoke("RestorePreviousText", 3.0f);
        }
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

    //this function restores the text that was replaced by the not enough coins prompt
    public void RestorePreviousText()
    {
        GetComponent<UnityEngine.UI.Text>().text = "Buy For 5000 Coins";
        SetString("NotEnoughCoinsForPink", "False");
    }
}
