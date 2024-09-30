//import libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangePinkSkinButtonText : MonoBehaviour
{
    //initialize variables
    public string PinkSkinOwned;

    //this function is called once when the scene is first loaded
    //this function displays an option for selecting the pink skin if it is owned
    public void Start()
    {
        PinkSkinOwned = GetString("PinkOwned");

        if (PinkSkinOwned == "True")
        {
            GetComponent<UnityEngine.UI.Text>().text = "Pink Skin";
        }
    }

    //this function retrieves that value at the specified keyname from the playerprefs dictionary
    public string GetString(string Keyname)
    {
        return PlayerPrefs.GetString(Keyname);
    }
}
