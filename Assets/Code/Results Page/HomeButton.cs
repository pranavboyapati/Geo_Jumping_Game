//import libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeButton : MonoBehaviour
{
    //this function laods the main menu page and ensures all values that update as the user plays the level are reset
    public void Clicked()
    {
        SceneManager.LoadScene("MainMenuScene");
        SetString("SelectedSkin", "None");
        SetFloat("PlayerXPosition", 0f);
        SetFloat("PlayerYPosition", 0f);
        SetInt("Score", 0);
    }

    //this function sets the playerprefs value of the specified key to the specified value when the value is a string
    public void SetString(string Keyname, string Value)
    {
        PlayerPrefs.SetString(Keyname, Value);
    }

    //this function sets the playerprefs value of the specified key to the specified value when the value is an integer
    public void SetInt(string Keyname, int Value)
    {
        PlayerPrefs.SetInt(Keyname, Value);
    }

    //this function sets the playerprefs value of the specified key to the specified value when the value is a float
    public void SetFloat(string Keyname, float Value)
    {
        PlayerPrefs.SetFloat(Keyname, Value);
    }
}
