//import libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    //initialize variables
    public Renderer RedSkin;
    public Renderer PinkSkin;
    public Renderer GreenSkin;
    public Renderer YellowSkin;

    public float Xposition;
    public float Yposition;
    public string SelectedSkin;
    
    //this function stores all values that should be restored when the game is resumed and loads the pause menu
    public void PauseClicked()
    {
        SelectedSkin = GetString("SelectedSkin");

        if (SelectedSkin == "Red")
        {
            Xposition = RedSkin.GetComponent<Transform>().position.x;
            Yposition = RedSkin.GetComponent<Transform>().position.y;
        }
        if (SelectedSkin == "Yellow")
        {
            Xposition = YellowSkin.GetComponent<Transform>().position.x;
            Yposition = YellowSkin.GetComponent<Transform>().position.y;
        }
        if (SelectedSkin == "Pink")
        {
            Xposition = PinkSkin.GetComponent<Transform>().position.x;
            Yposition = PinkSkin.GetComponent<Transform>().position.y;
        }
        if (SelectedSkin == "Green")
        {
            Xposition = GreenSkin.GetComponent<Transform>().position.x;
            Yposition = GreenSkin.GetComponent<Transform>().position.y;
        }

        SetFloat("PlayerXPosition", Xposition);
        SetFloat("PlayerYPosition", Yposition);

        SceneManager.LoadScene("PauseScene");
    }

    //this function stores the specified value at the specified keyname in the playerprefs dictionary
    public void SetFloat(string Keyname, float Value)
    {
        PlayerPrefs.SetFloat(Keyname, Value);
    }

    //this function retreives the value at the specified keyname from the playerprefs dictionary
    public string GetString(string Keyname)
    {
        return PlayerPrefs.GetString(Keyname);
    }
}
