//import libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollidedWithObject : MonoBehaviour
{
    //initialize variables
    public Renderer RedSkin;
    public Renderer PinkSkin;
    public Renderer GreenSkin;
    public Renderer YellowSkin;

    public float Xposition;
    public float Yposition;
    public string SelectedSkin;

    //this function is called once when the page is first loaded
    //this function retrieves the value for what character/skin the user is playing as
    public void Start()
    {
        SelectedSkin = GetString("SelectedSkin");
    }
    
    //this function is called once every frame update
    //this function checks if the player collided with an obstacle and ends the game if they did
    public void Update()
    {
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


        if (Xposition > -1.84f && Xposition < 1.84f && Yposition < -1.67f)  //1
        {
            SceneManager.LoadScene("ResultsScene");
        }
        
        if (Xposition > -0.26f && Xposition < 3.44f && Yposition < -1.67f)  //2
        {
            SceneManager.LoadScene("ResultsScene");
        }
        
        if (Xposition > 1.34f && Xposition < 5.02f && Yposition < -1.67f)  //3
        {
            SceneManager.LoadScene("ResultsScene");
        }
        
        if (Xposition > 2.98f && Xposition < 6.66f && Yposition < -1.67f)  //4
        {
            SceneManager.LoadScene("ResultsScene");
        }

        if (Xposition > 7.18f && Xposition < 10.85f && Yposition < -1.67f)  //8
        {
            SceneManager.LoadScene("ResultsScene");
        }
        
        if (Xposition > 20.37f && Xposition < 25.64f && Yposition < -1.16f)  //10
        {
            SceneManager.LoadScene("ResultsScene");
        }
        
        if (Xposition > 26.33f && Xposition < 29.94f && Yposition > -0.68f)  //11
        {
            SceneManager.LoadScene("ResultsScene");
        }
        
        if (Xposition > 31.16f && Xposition < 34.84f && Yposition < -1.67f)  //12
        {
            SceneManager.LoadScene("ResultsScene");
        }
        
        if (Xposition > 32.8f && Xposition < 37.2f && Yposition < -1.39f)  //13
        {
            SceneManager.LoadScene("ResultsScene");
        }
        
        if (Xposition > 34.71f && Xposition < 38.36f && Yposition > -0.67f)  //16
        {
            SceneManager.LoadScene("ResultsScene");
        }
        
        if (Xposition > 39.27f && Xposition < 42.95f && Yposition > -0.78f)  //17
        {
            SceneManager.LoadScene("ResultsScene");
        }
        
        if (Xposition > 39.46f && Xposition < 43.17f && Yposition < 1.08f && Yposition > -3.07f)  //18
        {
            SceneManager.LoadScene("ResultsScene");
        }
    }

    //this function retrives the value at the specified keyname in the playerprefs dictionary if the value is a string
    public string GetString(string Keyname)
    {
        return PlayerPrefs.GetString(Keyname);
    }
}
