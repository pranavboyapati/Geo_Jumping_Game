//import libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyYellowButton : MonoBehaviour
{
    //initialize variables
    public string yellowSkinOwned;
    
    //this function is called once per frame update
    //this function removes the purchase button component if the skin is owned
    public void Update()
    {
        yellowSkinOwned = GetString("YellowOwned");

        if (yellowSkinOwned == "True")
        {
            Destroy(GetComponent<Button>());
        }
    }

    //this function retreives the value stored at the specified keyname in the playerprefs dictionary
    public string GetString(string Keyname)
    {
        return PlayerPrefs.GetString(Keyname);
    }
}
