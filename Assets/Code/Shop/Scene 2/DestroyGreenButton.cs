//import libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyGreenButton : MonoBehaviour
{
    //initialize variables
    public string greenSkinOwned;

    //this function is called once per frame update
    //this function removes the purchase button component if the skin is owned
    public void Update()
    {
        greenSkinOwned = GetString("GreenOwned");

        if (greenSkinOwned == "True")
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
