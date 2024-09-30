//import libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitClicked : MonoBehaviour
{
    //this function resets the values that update as the user plays the level
    public void Quit()
    {
        SetFloat("PlayerXPosition", 0f);
        SetFloat("PlayerYPosition", 0f);
        SetInt("Score", 0);

        SceneManager.LoadScene("MainMenuScene");
    }

    //this function sets the playerprefs value of the specified key to the specified value when the value is a float
    public void SetFloat(string Keyname, float Value)
    {
        PlayerPrefs.SetFloat(Keyname, Value);
    }
    
    //this function sets the playerprefs value of the specified key to the specified value when the value is an integer
    public void SetInt(string Keyname, int Value)
    {
        PlayerPrefs.SetInt(Keyname, Value);
    }
}
