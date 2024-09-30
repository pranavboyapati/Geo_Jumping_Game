//import libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeGreenSkinButtonText : MonoBehaviour
{
    //initialize variables
    public string GreenSkinOwned;

    //this function is called once when the page is first loaded
    //this function creates an option for selecting the green skin if it is owned
    public void Start()
    {
        GreenSkinOwned = GetString("GreenOwned");

        if (GreenSkinOwned == "True")
        {
            GetComponent<UnityEngine.UI.Text>().text = "Green Skin";
        }
    }

    //this function retrieves the value at the specified keyname from the playerprefs dictionary
    public string GetString(string Keyname)
    {
        return PlayerPrefs.GetString(Keyname);
    }
}
