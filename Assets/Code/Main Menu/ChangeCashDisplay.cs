//import libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeCashDisplay : MonoBehaviour
{
    //initialize variables
    public int coins;
    public string coinsAsString;
    
    //this function is called once every frame update
    //this function gets the number of coins the player has and displays it
    public void Update()
    {
        coins = GetInt("Coins");
        coinsAsString = coins.ToString();

        GetComponent<UnityEngine.UI.Text>().text = "Coins: " + coinsAsString;
    }

    //this function gets the playerprefs value of the specified key only if the value if an integer
    public int GetInt(string Keyname)
    {
        return PlayerPrefs.GetInt(Keyname);
    }
}
