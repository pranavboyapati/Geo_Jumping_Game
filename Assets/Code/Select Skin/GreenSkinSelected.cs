//import libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GreenSkinSelected : MonoBehaviour
{
    //initialize variables
    public string GreenSkinOwned;
    
    //this function stores what skin the user is playing as and loads the main runner scene
    public void Clicked()
    {
        GreenSkinOwned = GetString("GreenOwned");
        
        if (GreenSkinOwned == "True")
        {
            SetString("SelectedSkin", "Green");
            SceneManager.LoadScene("RunnerScene");
        }
    }

    //this function stores the specified value at the specified keyname in the playerprefs dictionary
    public void SetString(string Keyname, string Value)
    {
        PlayerPrefs.SetString(Keyname, Value);
    }

    //this function retrieves the value at the specified keyname in the playerprefs dictionary
    public string GetString(string Keyname)
    {
        return PlayerPrefs.GetString(Keyname);
    }
}
