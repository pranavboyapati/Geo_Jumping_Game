//import libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeYellowSkinButtonText : MonoBehaviour
{
    //initialize variables
    public string YellowSkinOwned;
    
    //this function is called once when the page is first loaded
    //this function displays an option for selecting the yellow skin if it is purchased
    public void Start()
    {
        YellowSkinOwned = GetString("YellowOwned");

        if (YellowSkinOwned == "True")
        {
            GetComponent<UnityEngine.UI.Text>().text = "Yellow Skin";
        }
    }

    public string GetString(string Keyname)
    {
        return PlayerPrefs.GetString(Keyname);
    }
}
