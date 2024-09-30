//import libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Resume : MonoBehaviour
{
    //initialize variables
    public string GameState;
    public float Xposition;
    public float Yposition;

    public Renderer RedSkin;
    public Renderer YellowSkin;
    public Renderer PinkSkin;
    public Renderer GreenSkin;

    public Camera MainCamera;
    
    //this function is called once when the page is first loaded
    //this function restores the game to the exact state it was in before the user paused it
    public void Start()
    {
        GameState = GetString("GameState");

        if (GameState == "Resumed")
        {
            Xposition = GetFloat("PlayerXPosition");
            Yposition = GetFloat("PlayerYPosition");

            RedSkin.transform.position = new Vector3(Xposition, Yposition, -1f);
            YellowSkin.transform.position = new Vector3(Xposition, Yposition, -1f);
            PinkSkin.transform.position = new Vector3(Xposition, Yposition, -1f);
            GreenSkin.transform.position = new Vector3(Xposition, Yposition, -1f);

            MainCamera.transform.position = new Vector3(Xposition, 0f, -10f);

            SetString("GameState", "Normal");
        }
    }

    //this function retrieves the value at the specified keyname from the playerprefs dictionary
    public string GetString(string Keyname)
    {
        return PlayerPrefs.GetString(Keyname);
    }

    //this function retrieves the value at the specified keyname from the playerprefs dictionary
    public float GetFloat(string Keyname)
    {
        return PlayerPrefs.GetFloat(Keyname);
    }

    //this function stores the specified value at the specified keyname in the playerprefs dictionary
    public void SetString(string Keyname, string Value)
    {
        PlayerPrefs.SetString(Keyname, Value);
    }
}
