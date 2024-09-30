//import libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RedSkinSelected : MonoBehaviour
{
    //this function stores what skin the user is playing as and loads the main runner scene
    public void Clicked()
    {
        SetString("SelectedSkin", "Red");
        SceneManager.LoadScene("RunnerScene");
    }

    //this function stores the specified value at the specified keyname in the playerprefs dictionary
    public void SetString(string Keyname, string Value)
    {
        PlayerPrefs.SetString(Keyname, Value);
    }
}
