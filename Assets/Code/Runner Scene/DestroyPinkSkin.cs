//import libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyPinkSkin : MonoBehaviour
{
    //initialize variables
    public string PlayerSkin;
    
    //this function is called once when the page is first loaded
    //this function removes the green skin if it is not the one the user is going to play with
    public void Start()
    {
        PlayerSkin = GetString("SelectedSkin");

        if (PlayerSkin != "Pink")
        {
            Destroy(GetComponent<Renderer>());
        }
    }

    //this function retrieves the value at the specified keyname in the playerprefs dictionary if the value is a string
    public string GetString(string Keyname)
    {
        return PlayerPrefs.GetString(Keyname);
    }
}
