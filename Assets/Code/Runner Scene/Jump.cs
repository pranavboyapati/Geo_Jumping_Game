//import libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Jump : MonoBehaviour
{
    //initialize variables
    public string SelectedSkin;
    public string WhetherToJump;
    public float velocity;
    public float gravity = -9.81f;
    public float Xposition;
    public float Yposition;

    public Renderer RedSkin;
    public Renderer PinkSkin;
    public Renderer GreenSkin;
    public Renderer YellowSkin;

    //this function is called once when the page is first loaded
    //this function determines what character/skin the user is playing as
    public void Start()
    {
        SelectedSkin = GetString("SelectedSkin");
    }

    //this function is called once every frame update
    //this function controls the jumping motion, ensuring the upwards motion and downwards motion are smooth and occur at a realistic velocity
    public void Update()
    {
        WhetherToJump = GetString("Jumped");
        
        if (WhetherToJump == "True")
        {
            velocity = 7f;

            if (SelectedSkin == "Red")
            {
                RedSkin.transform.Translate(new Vector3(0, velocity, 0) * Time.deltaTime);
            }
            if (SelectedSkin == "Yellow")
            {
                YellowSkin.transform.Translate(new Vector3(0, velocity, 0) * Time.deltaTime);
            }
            if (SelectedSkin == "Pink")
            {
                PinkSkin.transform.Translate(new Vector3(0, velocity, 0) * Time.deltaTime);
            }
            if (SelectedSkin == "Green")
            {
                GreenSkin.transform.Translate(new Vector3(0, velocity, 0) * Time.deltaTime);
            }
        }

        if (WhetherToJump == "False")
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

            velocity += gravity * Time.deltaTime;

            if ((Xposition < -2.935f || Xposition > 7.615f) && Yposition > -3.68f)
            {
                if (SelectedSkin == "Red")
                {
                    RedSkin.transform.Translate(new Vector3(0, velocity, 0) * Time.deltaTime);
                }
                if (SelectedSkin == "Yellow")
                {
                    YellowSkin.transform.Translate(new Vector3(0, velocity, 0) * Time.deltaTime);
                }
                if (SelectedSkin == "Pink")
                {
                    PinkSkin.transform.Translate(new Vector3(0, velocity, 0) * Time.deltaTime);
                }
                if (SelectedSkin == "Green")
                {
                    GreenSkin.transform.Translate(new Vector3(0, velocity, 0) * Time.deltaTime);
                }
            }

            else if ((Xposition > -2.935f || Xposition < 7.615f) && Yposition > -1.16f)
            {
                if (SelectedSkin == "Red")
                {
                    RedSkin.transform.Translate(new Vector3(0, velocity, 0) * Time.deltaTime);
                }
                if (SelectedSkin == "Yellow")
                {
                    YellowSkin.transform.Translate(new Vector3(0, velocity, 0) * Time.deltaTime);
                }
                if (SelectedSkin == "Pink")
                {
                    PinkSkin.transform.Translate(new Vector3(0, velocity, 0) * Time.deltaTime);
                }
                if (SelectedSkin == "Green")
                {
                    GreenSkin.transform.Translate(new Vector3(0, velocity, 0) * Time.deltaTime);
                }
            }
        }
    }

    //this function retrieves the value at the specified keyname in the playerprefs dictionary if the value is a string
    public string GetString(string Keyname)
    {
        return PlayerPrefs.GetString(Keyname);
    }
}
