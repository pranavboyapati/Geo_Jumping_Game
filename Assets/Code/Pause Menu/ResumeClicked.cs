//import libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResumeClicked : MonoBehaviour
{
    //this function returns the player to the exact stage they were in before pausing the game
    public void Resume()
    {
        SceneManager.LoadScene("RunnerScene");
        SetString("GameState", "Resumed");
    }

    //this function sets the playerprefs value of the specified key to the specified value when the value is a string
    public void SetString(string Keyname, string Value)
    {
        PlayerPrefs.SetString(Keyname, Value);
    }
}
