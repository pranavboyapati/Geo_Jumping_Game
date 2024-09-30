//import libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreDisplay : MonoBehaviour
{
    //initialize variables
    public int Score;
    
    //this function is called once when the page is first loaded
    //this function retrieves and displays the player's score
    public void Start()
    {
        Score = GetInt("Score");
        GetComponent<UnityEngine.UI.Text>().text = "Final Score: " + Score;
    }

    //this function retreives the integer at the specified keyname from the playerprefs dictionary
    public int GetInt(string Keyname)
    {
        return PlayerPrefs.GetInt(Keyname);
    }
}
