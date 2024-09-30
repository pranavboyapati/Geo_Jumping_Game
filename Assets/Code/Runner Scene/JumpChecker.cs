//import libraries
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class JumpChecker : MonoBehaviour
{
    //this function controls a variable for determining when the upwards motion of the jump ends and when the downwards motion begins
    public async void Jumped()
    {
        PlayerPrefs.SetString("Jumped", "True");
        await Task.Delay(150);
        PlayerPrefs.SetString("Jumped", "False");
    }
}
