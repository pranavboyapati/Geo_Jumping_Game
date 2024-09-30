//import libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeYellowButtonText : MonoBehaviour
{
    //initialize variables
    public string yellowOwnedStatus;
    
    //this function is called once per frame update
    //this function updates the purchase text to tell the user that they own the skin, if this is the case
    public void Update()
    {
        yellowOwnedStatus = GetString("YellowOwned");

        if (yellowOwnedStatus == "True")
        {
            GetComponent<UnityEngine.UI.Text>().text = "Skin Owned";
        }
    }

    //this function retreives the value stored at the specified keyname in the playerprefs dictionary
    public string GetString(string Keyname)
    {
        return PlayerPrefs.GetString(Keyname);
    }
}
